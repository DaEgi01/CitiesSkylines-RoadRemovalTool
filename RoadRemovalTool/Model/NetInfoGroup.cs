using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RoadRemovalTool.Model
{
    public class NetInfoGroup
    {
        private readonly List<NetInfoDemolishAndReplacementModel> _netInfoReplacementModels;

        public NetInfoGroup(string modName, RoadUiCategory roadUiCategory, bool isRedundant, List<NetInfoDemolishAndReplacementModel> netInfoReplacementModels = null)
        {
            ModName = modName ?? throw new ArgumentNullException(nameof(modName));
            RoadUiCategory = roadUiCategory;
            IsRedundant = isRedundant;

            if (netInfoReplacementModels == null) throw new ArgumentNullException(nameof(netInfoReplacementModels));
            if (netInfoReplacementModels.Count < 1) throw new ArgumentException(nameof(netInfoReplacementModels) + " must contain at least one element.");

            _netInfoReplacementModels = netInfoReplacementModels;
        }

        public string ModName { get; }

        public string SystemNameOriginal => _netInfoReplacementModels[0].SystemNameOriginal;

        public string SystemNameReplacement => NetInfoReplacementModels[0].SystemNameReplacement;

        public RoadUiCategory RoadUiCategory { get; }

        public bool IsRedundant { get; }

        public ReadOnlyCollection<NetInfoDemolishAndReplacementModel> NetInfoReplacementModels => _netInfoReplacementModels.AsReadOnly();

        public ReplacementOption ReplacementOption
        {
            get
            {
                if (NetInfoReplacementModels.All(x => x.HasReplacement))
                {
                    return ReplacementOption.Fully;
                }

                if (NetInfoReplacementModels.Any(x => x.HasReplacement))
                {
                    return ReplacementOption.Partially;
                }

                return ReplacementOption.None;
            }
        }

        public bool HasAnyReplacements => NetInfoReplacementModels.Any(x => x.HasReplacement);
    }
}
