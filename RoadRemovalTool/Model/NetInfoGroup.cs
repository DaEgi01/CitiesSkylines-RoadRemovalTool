using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RoadRemovalTool.Model
{
    public class NetInfoGroup
    {
        private readonly List<NetInfoDemolishAndReplacementModel> netInfoReplacementModels;

        public NetInfoGroup(string modName, RoadUiCategory roadUiCategory, bool isRedundant, List<NetInfoDemolishAndReplacementModel> netInfoReplacementModels = null)
        {
            this.ModName = modName ?? throw new ArgumentNullException(nameof(modName));
            this.RoadUiCategory = roadUiCategory;
            this.IsRedundant = isRedundant;

            if (netInfoReplacementModels == null) throw new ArgumentNullException(nameof(netInfoReplacementModels));
            if (netInfoReplacementModels.Count < 1) throw new ArgumentException(nameof(netInfoReplacementModels) + " must contain at least one element.");

            this.netInfoReplacementModels = netInfoReplacementModels;
        }

        public string ModName { get; }

        public string SystemNameOriginal => this.netInfoReplacementModels[0].SystemNameOriginal;

        public string SystemNameReplacement => this.NetInfoReplacementModels[0].SystemNameReplacement;

        public RoadUiCategory RoadUiCategory { get; }

        public bool IsRedundant { get; }

        public ReadOnlyCollection<NetInfoDemolishAndReplacementModel> NetInfoReplacementModels => this.netInfoReplacementModels.AsReadOnly();

        public ReplacementOption ReplacementOption
        {
            get
            {
                if (this.NetInfoReplacementModels.All(x => x.HasReplacement))
                {
                    return ReplacementOption.Fully;
                }

                if (this.NetInfoReplacementModels.Any(x => x.HasReplacement))
                {
                    return ReplacementOption.Partially;
                }

                return ReplacementOption.None;
            }
        }

        public bool HasAnyReplacements => this.NetInfoReplacementModels.Any(x => x.HasReplacement);
    }
}
