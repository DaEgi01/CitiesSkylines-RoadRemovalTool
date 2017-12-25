using System.Collections.ObjectModel;

namespace RoadRemovalTool.Model
{
    public class NetInfoGroupViewReadModel
    {
        private readonly NetInfoGroup netInfoGroup;

        public NetInfoGroupViewReadModel(NetInfoGroup netInfoGroup, bool prefabFound, string displayNameOriginal = null, string displayNameReplacement = null)
        {
            this.netInfoGroup = netInfoGroup ?? throw new System.ArgumentNullException(nameof(netInfoGroup));
            this.PrefabFound = prefabFound;

            if (prefabFound)
            {
                //if the prefab was found, 
                this.DisplayNameOriginal = displayNameOriginal ?? throw new System.ArgumentNullException(nameof(displayNameOriginal));

                if (this.netInfoGroup.HasAnyReplacements)
                {
                    this.DisplayNameReplacement = displayNameReplacement ?? throw new System.ArgumentNullException(nameof(displayNameReplacement));
                }
            }
        }

        public bool PrefabFound { get; }
        public string DisplayNameOriginal { get; }
        public string DisplayNameReplacement { get; }

        public string ModName => this.netInfoGroup.ModName;
        public string SystemNameOriginal => this.netInfoGroup.SystemNameOriginal;
        public string SystemNameReplacement => this.netInfoGroup.SystemNameReplacement;
        public RoadUiCategory RoadUiCategory => this.netInfoGroup.RoadUiCategory;
        public bool IsRedundant => this.netInfoGroup.IsRedundant;

        public ReadOnlyCollection<NetInfoDemolishAndReplacementModel> NetInfoReplacementModels => this.netInfoGroup.NetInfoReplacementModels;
        public ReplacementOption ReplacementOption => this.netInfoGroup.ReplacementOption;
        public bool HasAnyReplacements => this.netInfoGroup.HasAnyReplacements;
    }
}
