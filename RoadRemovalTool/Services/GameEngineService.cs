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
                    DemolishNetSegments(netInfoReplacementModel.SystemNameOriginal);
                }

                _coverageManager.CoverageUpdated(ItemClass.Service.None, ItemClass.SubService.None, ItemClass.Level.None);
                _netManager.m_nodesUpdated = true;
            });

            Debug.Log($"Demolish of {netInfoGroupViewReadModel.DisplayNameOriginal} completed.");
        }

        public void DemolishSegment(string netInfoSegmentName)
        {
            _simulationManager.AddAction(() =>
            {
                DemolishNetSegments(netInfoSegmentName);
            });

            Debug.Log($"Demolish of {netInfoSegmentName} completed.");
        }

        public void ColorizeSegmentGroup(NetInfoGroupViewReadModel netInfoGroupViewReadModel)
        {
            _simulationManager.AddAction(() =>
            {
                foreach (var netInfoReplacementModel in netInfoGroupViewReadModel.NetInfoReplacementModels)
                {
                    ColorizeNetSegments(netInfoReplacementModel.SystemNameOriginal);
                }
            });

            Debug.Log($"Colorization of {netInfoGroupViewReadModel.DisplayNameOriginal} completed.");
        }

        public void ColorizeSegment(string netInfoSegmentName)
        {
            _simulationManager.AddAction(() =>
            {
                ColorizeNetSegments(netInfoSegmentName);
            });

            Debug.Log($"Colorization of {netInfoSegmentName} completed.");
        }

        public void UpgradeSegmentGroup(NetInfoGroupViewReadModel netInfoGroupViewReadModel)
        {
            _simulationManager.AddAction(() =>
            {
                foreach (var netInfoReplacementModel in netInfoGroupViewReadModel.NetInfoReplacementModels)
                {
                    if (!netInfoReplacementModel.HasReplacement)
                    {
                        continue;
                    }

                    UpgradeNetSegments(netInfoReplacementModel.SystemNameOriginal, netInfoReplacementModel.SystemNameReplacement);
                }
            });

            Debug.Log($"Replacement of {netInfoGroupViewReadModel.DisplayNameOriginal} completed.");
        }

        public void UpgradeSegment(string netInfoSegmentNameOriginal, string netInfoSegmentNameReplacement)
        {
            _simulationManager.AddAction(() =>
            {
                UpgradeNetSegments(netInfoSegmentNameOriginal, netInfoSegmentNameReplacement);
            });

            Debug.Log($"Replacement of {netInfoSegmentNameOriginal} completed.");
        }

        private void DemolishNetSegments(string netInfoSegmentName)
        {
            var netSegmentIds = GetNetSegmentIds(netInfoSegmentName);
            foreach (var segmentId in netSegmentIds)
            {
                ref var segment = ref _netManager.m_segments.m_buffer[segmentId];
                segment.Info.m_netAI.ManualDeactivation(segmentId, ref segment);
                _netManager.ReleaseSegment(segmentId, false);
            }

            _coverageManager.CoverageUpdated(ItemClass.Service.None, ItemClass.SubService.None, ItemClass.Level.None);
            _netManager.m_nodesUpdated = true;
        }

        private void ColorizeNetSegments(string netInfoSegmentName)
        {
            var netInfo = PrefabCollection<NetInfo>.FindLoaded(netInfoSegmentName);
            if (netInfo == null)
                return;

            netInfo.m_color = new Color(1f, 0f, 1f);
            _netManager.UpdateSegmentColors();
        }

        private void UpgradeNetSegments(string netInfoSegmentNameOriginal, string netInfoSegmentNameReplacement)
        {
            var replacementNetInfo = PrefabCollection<NetInfo>.FindLoaded(netInfoSegmentNameReplacement);
            if (replacementNetInfo == null)
            {
                return;
            }

            var randomizer = new Randomizer();
            var netSegmentIds = GetNetSegmentIds(netInfoSegmentNameOriginal);
            foreach (var netSegmentId in netSegmentIds)
            {
                ref var segment = ref _netManager.m_segments.m_buffer[netSegmentId];
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

            _coverageManager.CoverageUpdated(ItemClass.Service.None, ItemClass.SubService.None, ItemClass.Level.None);
            _netManager.m_nodesUpdated = true;
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
