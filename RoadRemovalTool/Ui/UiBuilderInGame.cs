using ColossalFramework.UI;
using ICities;
using RoadRemovalTool.Model;
using RoadRemovalTool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RoadRemovalTool.Ui
{
    public class UiBuilderInGame : IUiBuilder
    {
        private readonly UIHelperBase uIHelperBase;
        private readonly ModFullTitle modFullTitle;
        private readonly GameEngineService gameEngineService;
        private readonly List<NetInfoGroupViewReadModel> netInfoGroupViewReadModel;

        private int selectedIndex = 0;
        private UIPanel[] modPanels;

        public UiBuilderInGame(UIHelperBase uIHelperBase, ModFullTitle modFullTitle, GameEngineService gameEngineService, List<NetInfoGroupViewReadModel> netInfoGroupReadModel)
        {
            this.uIHelperBase = uIHelperBase ?? throw new ArgumentNullException(nameof(uIHelperBase));
            this.modFullTitle = modFullTitle ?? throw new ArgumentNullException(nameof(modFullTitle));
            this.gameEngineService = gameEngineService ?? throw new ArgumentNullException(nameof(gameEngineService));
            if (netInfoGroupReadModel.Count < 1) throw new ArgumentException(nameof(netInfoGroupReadModel) + " must contain at least one element.");
            this.netInfoGroupViewReadModel = netInfoGroupReadModel ?? throw new ArgumentNullException(nameof(netInfoGroupReadModel));
        }

        private void ShowModPanel(int index)
        {
            if (index == 0)
            {
                return;
            }

            this.modPanels[this.selectedIndex].isVisible = false;
            this.modPanels[index].isVisible = true;
            this.selectedIndex = index;

            var mainHelper = this.uIHelperBase as UIHelper;
            var mainPanel = mainHelper.self as UIScrollablePanel;
        }

        public void BuildUi()
        {
            var relevantSortedModNames = this.netInfoGroupViewReadModel.Where(x => x.PrefabFound).Select(x => x.ModName).Distinct().OrderBy(x => x).ToList();
            if (relevantSortedModNames.Count == 0)
            {
                var mainGroupUiHelper = this.uIHelperBase.AddGroup(this.modFullTitle) as UIHelper;

                var mainPanel = mainGroupUiHelper.self as UIPanel;
                var mainLabel = mainPanel.AddUIComponent<UILabel>();
                mainLabel.text = "Did not find any roads that are supported.";

                return;
            }

            this.modPanels = new UIPanel[relevantSortedModNames.Count];

            var mainHelper = this.uIHelperBase as UIHelper;
            var mainGroupHelper = this.uIHelperBase.AddGroup(this.modFullTitle) as UIHelper;
            var mainGroupPanel = mainGroupHelper.self as UIPanel;
            mainGroupPanel.backgroundSprite = null;

            var modDropDown = mainGroupHelper.AddDropdown("Mod", relevantSortedModNames.ToArray(), 0, (index) => this.ShowModPanel(index)) as UIDropDown;
            modDropDown.textFieldPadding = new RectOffset(8, 8, 8, 8);
            modDropDown.width = modDropDown.CalculatePopupWidth(0);

            mainGroupHelper.AddSpace(10);

            for (var i = 0; i < relevantSortedModNames.Count; i++)
            {
                var modPanel = mainGroupPanel.AddUIComponent<UIPanel>();
                modPanel.isVisible = false;
                modPanel.width = mainGroupPanel.width - 20;
                modPanel.name = "RRT_UIPanel_" + relevantSortedModNames[i];
                var modPanelHelper = new UIHelper(modPanel);

                this.modPanels[i] = modPanel;

                var modNetInfoGroupViewReadModel = this.netInfoGroupViewReadModel
                    .Where(x => 
                        x.PrefabFound 
                        && x.ModName == relevantSortedModNames[i]
                    );

                var roadUiCategories = modNetInfoGroupViewReadModel.Select(x => x.RoadUiCategory).Distinct().OrderBy(x => x);
                foreach (var roadUiCategory in roadUiCategories)
                {
                    var subGroupHelper = modPanelHelper.AddGroup(Enum.GetName(typeof(RoadUiCategory), roadUiCategory)) as UIHelper;
                    var subGroupPanel = subGroupHelper.self as UIPanel;

                    var offset = 10;
                    var netInfoGroupPanelHeight = 48;

                    var roadUiCategoryNetInfoGroupViewReadModels = modNetInfoGroupViewReadModel.Where(x => x.RoadUiCategory == roadUiCategory);
                    foreach (var netInfoGroupViewReadModel in roadUiCategoryNetInfoGroupViewReadModels)
                    {
                        var netInfoGroupPanel = subGroupPanel.AddUIComponent<UIPanel>();
                        netInfoGroupPanel.height = netInfoGroupPanelHeight;
                        netInfoGroupPanel.width = subGroupPanel.width - 60;
                        netInfoGroupPanel.relativePosition = new Vector3(0, offset);
                        offset += netInfoGroupPanelHeight;

                        var label = netInfoGroupPanel.AddUIComponent<UILabel>();
                        label.text = netInfoGroupViewReadModel.DisplayNameOriginal;
                        label.relativePosition = new Vector3(0, 8);
                        if (netInfoGroupViewReadModel.IsRedundant)
                        {
                            label.text += " (Redundant)";
                            label.textColor = new Color32(200, 100, 100, 255);
                        }

                        var netInfoGroupHelper = new UIHelper(netInfoGroupPanel);

                        var netGroupDemolishButton = netInfoGroupHelper.AddButton("Demolish", () => this.gameEngineService.DemolishSegmentGroup(netInfoGroupViewReadModel)) as UIButton;
                        netGroupDemolishButton.textHorizontalAlignment = UIHorizontalAlignment.Center;
                        netGroupDemolishButton.relativePosition = new Vector3(netInfoGroupPanel.width - netGroupDemolishButton.width, 0);

                        if (netInfoGroupViewReadModel.HasAnyReplacements)
                        {
                            var netGroupReplaceButton = netInfoGroupHelper.AddButton("Replace", () => this.gameEngineService.UpgradeSegmentGroup(netInfoGroupViewReadModel)) as UIButton;
                            netGroupReplaceButton.tooltip = "with " + netInfoGroupViewReadModel.DisplayNameReplacement;
                            netGroupReplaceButton.textHorizontalAlignment = UIHorizontalAlignment.Center;
                            netGroupReplaceButton.relativePosition = new Vector3(netInfoGroupPanel.width - netGroupDemolishButton.width - netGroupReplaceButton.width - 10, 0);
                        }
                    }

                    modPanel.autoFitChildrenVertically = true;
                    modPanel.autoLayoutDirection = LayoutDirection.Vertical;
                    modPanel.autoLayout = true;
                }
            }

            this.ShowModPanel(this.selectedIndex);
        }
    }
}
