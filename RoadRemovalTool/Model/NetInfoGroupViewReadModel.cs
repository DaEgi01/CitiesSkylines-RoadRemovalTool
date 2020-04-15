using System;
using System.Collections.ObjectModel;

namespace RoadRemovalTool.Model
{
    public class NetInfoGroupViewReadModel
    {
        private readonly NetInfoGroup _netInfoGroup;

        public NetInfoGroupViewReadModel(NetInfoGroup netInfoGroup, bool prefabFound, string displayNameOriginal = null, string displayNameReplacement = null)
        {
            _netInfoGroup = netInfoGroup ?? throw new ArgumentNullException(nameof(netInfoGroup));
            PrefabFound = prefabFound;

            if (prefabFound)
            {
                DisplayNameOriginal = displayNameOriginal ?? throw new ArgumentNullException(nameof(displayNameOriginal));

                if (_netInfoGroup.HasAnyReplacements)
                {
                    DisplayNameReplacement = displayNameReplacement ?? throw new ArgumentNullException(nameof(displayNameReplacement) + "; SystemNameOriginal: " + netInfoGroup.SystemNameOriginal + "; Replacement: " + netInfoGroup.SystemNameReplacement);
                }
            }
        }

        public bool PrefabFound { get; }
        public string DisplayNameOriginal { get; }
        public string DisplayNameReplacement { get; }

        public string ModName => _netInfoGroup.ModName;
        public string SystemNameOriginal => _netInfoGroup.SystemNameOriginal;
        public string SystemNameReplacement => _netInfoGroup.SystemNameReplacement;
        public RoadUiCategory RoadUiCategory => _netInfoGroup.RoadUiCategory;
        public bool IsRedundant => _netInfoGroup.IsRedundant;

        public ReadOnlyCollection<NetInfoDemolishAndReplacementModel> NetInfoReplacementModels => _netInfoGroup.NetInfoReplacementModels;
        public ReplacementOption ReplacementOption => _netInfoGroup.ReplacementOption;
        public bool HasAnyReplacements => _netInfoGroup.HasAnyReplacements;
    }
}
