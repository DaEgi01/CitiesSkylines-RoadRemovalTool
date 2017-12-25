using ColossalFramework;
using ColossalFramework.Math;
using RoadRemovalTool.Model;
using System;
using System.Collections.Generic;

namespace RoadRemovalTool.Services
{
    public class GameEngineService
    {
        private readonly CoverageManager coverageManager;
        private readonly NetManager netManager;
        private readonly SimulationManager simulationManager;

        public GameEngineService(CoverageManager coverageManager, NetManager netManager, SimulationManager simulationManager)
        {
            this.coverageManager = coverageManager ?? throw new ArgumentNullException(nameof(coverageManager));
            this.netManager = netManager ?? throw new ArgumentNullException(nameof(netManager));
            this.simulationManager = simulationManager ?? throw new ArgumentNullException(nameof(simulationManager));
        }

        public void DemolishSegmentGroup(NetInfoGroupViewReadModel netInfoGroupViewReadModel)
        {
            this.simulationManager.AddAction(() =>
            {
                foreach (var netInfoReplacementModel in netInfoGroupViewReadModel.NetInfoReplacementModels)
                {
                    this.DemolishNetSegments(netInfoReplacementModel);
                }
            });

            coverageManager.CoverageUpdated(ItemClass.Service.None, ItemClass.SubService.None, ItemClass.Level.None);
            this.netManager.m_nodesUpdated = true;

            DebugOutputPanel.AddMessage(
                ColossalFramework.Plugins.PluginManager.MessageType.Warning,
                $"Demolish of {netInfoGroupViewReadModel.DisplayNameOriginal} completed."
            );
        }

        public void UpgradeSegmentGroup(NetInfoGroupViewReadModel netInfoGroupViewReadModel)
        {
            this.simulationManager.AddAction(() =>
            {
                foreach (var netInfoReplacementModel in netInfoGroupViewReadModel.NetInfoReplacementModels)
                {
                    this.UpgradeNetSegments(netInfoReplacementModel);
                }
            });

            //TODO check if anything else is necessary at this point

            DebugOutputPanel.AddMessage(
                ColossalFramework.Plugins.PluginManager.MessageType.Warning,
                $"Replacement of {netInfoGroupViewReadModel.DisplayNameOriginal} completed."
            );
        }

        private void DemolishNetSegments(NetInfoDemolishAndReplacementModel netInfoReplacementModel)
        {
            var netSegmentIds = this.GetNetSegmentIds(netInfoReplacementModel.SystemNameOriginal);
            foreach (var segmentId in netSegmentIds)
            {
                var segment = netManager.m_segments.m_buffer[segmentId];
                segment.Info.m_netAI.ManualDeactivation(segmentId, ref segment);
                netManager.ReleaseSegment(segmentId, false);
            }
        }

        private void UpgradeNetSegments(NetInfoDemolishAndReplacementModel netInfoReplacementModel)
        {
            if (!netInfoReplacementModel.HasReplacement)
            {
                return;
            }

            var replacementNetInfo = PrefabCollection<NetInfo>.FindLoaded(netInfoReplacementModel.SystemNameReplacement);
            if (replacementNetInfo == null)
            {
                return;
            }

            var randomizer = new Randomizer();
            var netSegmentIds = this.GetNetSegmentIds(netInfoReplacementModel.SystemNameOriginal);
            foreach (var netSegmentId in netSegmentIds)
            {
                var segment = netManager.m_segments.m_buffer[netSegmentId];
                segment.Info.m_netAI.ManualDeactivation(netSegmentId, ref segment);
                var direction = segment.GetDirection(netSegmentId);

                //create a new segment over the old segment
                netManager.CreateSegment(
                    out ushort newSegmentId,
                    ref randomizer,
                    replacementNetInfo,
                    segment.m_startNode,
                    segment.m_endNode,
                    segment.m_startDirection,
                    segment.m_endDirection,
                    segment.m_buildIndex,
                    Singleton<SimulationManager>.instance.m_currentBuildIndex,
                    (segment.m_flags & NetSegment.Flags.Invert) != NetSegment.Flags.None
                );

                //demolish the old segment
                segment.Info.m_netAI.ManualDeactivation(netSegmentId, ref segment);
                this.netManager.ReleaseSegment(netSegmentId, false);
            }
        }

        private List<ushort> GetNetSegmentIds(string netInfoSegmentName)
        {
            var result = new List<ushort>();

            var bufferLength = (ushort)netManager.m_segments.m_buffer.Length;
            for (ushort i = 0; i < bufferLength; i++)
            {
                var segment = netManager.m_segments.m_buffer[i];
                if (segment.Info == null)
                {
                    continue;
                }

                if (segment.Info.name == netInfoSegmentName)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
