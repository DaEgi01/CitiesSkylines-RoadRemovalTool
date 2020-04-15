using ColossalFramework;
using ColossalFramework.Math;
using RoadRemovalTool.Model;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace RoadRemovalTool.Services
{
    public class GameEngineService
    {
        private readonly CoverageManager _coverageManager;
        private readonly NetManager _netManager;
        private readonly SimulationManager _simulationManager;

        public GameEngineService(CoverageManager coverageManager, NetManager netManager, SimulationManager simulationManager)
        {
            _coverageManager = coverageManager ?? throw new ArgumentNullException(nameof(coverageManager));
            _netManager = netManager ?? throw new ArgumentNullException(nameof(netManager));
            _simulationManager = simulationManager ?? throw new ArgumentNullException(nameof(simulationManager));
        }

        public void DemolishSegmentGroup(NetInfoGroupViewReadModel netInfoGroupViewReadModel)
        {
            _simulationManager.AddAction(() =>
            {
                foreach (var netInfoReplacementModel in netInfoGroupViewReadModel.NetInfoReplacementModels)
                {
                    DemolishNetSegments(netInfoReplacementModel);
                }
            });

            _coverageManager.CoverageUpdated(ItemClass.Service.None, ItemClass.SubService.None, ItemClass.Level.None);
            _netManager.m_nodesUpdated = true;

            DebugOutputPanel.AddMessage(
                ColossalFramework.Plugins.PluginManager.MessageType.Warning,
                $"Demolish of {netInfoGroupViewReadModel.DisplayNameOriginal} completed."
            );
        }

        public void ColorizeSegmentGroup(NetInfoGroupViewReadModel netInfoGroupViewReadModel)
        {
            _simulationManager.AddAction(() =>
            {
                foreach (var netInfoReplacementModel in netInfoGroupViewReadModel.NetInfoReplacementModels)
                {
                    ColorizeNetSegments(netInfoReplacementModel);
                }
            });

            DebugOutputPanel.AddMessage(
                ColossalFramework.Plugins.PluginManager.MessageType.Warning,
                $"Colorization of {netInfoGroupViewReadModel.DisplayNameOriginal} completed."
            );
        }

        public void UpgradeSegmentGroup(NetInfoGroupViewReadModel netInfoGroupViewReadModel)
        {
            _simulationManager.AddAction(() =>
            {
                foreach (var netInfoReplacementModel in netInfoGroupViewReadModel.NetInfoReplacementModels)
                {
                    UpgradeNetSegments(netInfoReplacementModel);
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
            var netSegmentIds = GetNetSegmentIds(netInfoReplacementModel.SystemNameOriginal);
            foreach (var segmentId in netSegmentIds)
            {
                var segment = _netManager.m_segments.m_buffer[segmentId];
                segment.Info.m_netAI.ManualDeactivation(segmentId, ref segment);
                _netManager.ReleaseSegment(segmentId, false);
            }
        }

        private void ColorizeNetSegments(NetInfoDemolishAndReplacementModel netInfoReplacementModel)
        {
            var netSegmentIds = GetNetSegmentIds(netInfoReplacementModel.SystemNameOriginal);
            foreach (var segmentId in netSegmentIds)
            {
                var segment = _netManager.m_segments.m_buffer[segmentId];
                if (segment.Info == null)
                {
                    continue;
                }

                segment.m_wetness = 0;
                segment.Info.m_color = new Color(1f, 0f, 1f);
                _netManager.UpdateSegmentColors(segmentId);
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
            var netSegmentIds = GetNetSegmentIds(netInfoReplacementModel.SystemNameOriginal);
            foreach (var netSegmentId in netSegmentIds)
            {
                var segment = _netManager.m_segments.m_buffer[netSegmentId];
                segment.Info.m_netAI.ManualDeactivation(netSegmentId, ref segment);
                var direction = segment.GetDirection(netSegmentId);

                //create a new segment over the old segment
                _netManager.CreateSegment(
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
                _netManager.ReleaseSegment(netSegmentId, false);
            }
        }

        private List<ushort> GetNetSegmentIds(string netInfoSegmentName)
        {
            var result = new List<ushort>();

            var bufferLength = (ushort)_netManager.m_segments.m_buffer.Length;
            for (ushort i = 0; i < bufferLength; i++)
            {
                var segment = _netManager.m_segments.m_buffer[i];
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
