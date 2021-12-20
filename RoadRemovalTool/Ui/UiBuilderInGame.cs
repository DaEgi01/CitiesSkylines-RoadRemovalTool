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
        private readonly UIHelperBase _uIHelperBase;
        private readonly ModFullTitle _modFullTitle;
        private readonly GameEngineService _gameEngineService;
        private readonly List<NetInfoGroupViewReadModel> _netInfoGroupViewReadModel;

        private int _selectedIndex = 0;
        private UIPanel[] _modPanels;

        public UiBuilderInGame(UIHelperBase uIHelperBase, ModFullTitle modFullTitle, GameEngineService gameEngineService, List<NetInfoGroupViewReadModel> netInfoGroupReadModel)
        {
            _uIHelperBase = uIHelperBase ?? throw new ArgumentNullException(nameof(uIHelperBase));
            _modFullTitle = modFullTitle ?? throw new ArgumentNullException(nameof(modFullTitle));
            _gameEngineService = gameEngineService ?? throw new ArgumentNullException(nameof(gameEngineService));
            if (netInfoGroupReadModel.Count < 1) throw new ArgumentException(nameof(netInfoGroupReadModel) + " must contain at least one element.");
            _netInfoGroupViewReadModel = netInfoGroupReadModel ?? throw new ArgumentNullException(nameof(netInfoGroupReadModel));
        }

        private void ShowModPanel(int index)
        {
            _modPanels[_selectedIndex].isVisible = false;
            _modPanels[index].isVisible = true;
            _selectedIndex = index;
        }

        public void BuildUi()
        {
            var relevantSortedModNames = _netInfoGroupViewReadModel
                .Where(x => x.PrefabFound)
                .Select(x => x.ModName)
                .Distinct()
                .OrderBy(x => x)
                .ToList();
            relevantSortedModNames.Add("Custom");

            _modPanels = new UIPanel[relevantSortedModNames.Count];

            var mainHelper = _uIHelperBase as UIHelper;
            var mainGroupHelper = _uIHelperBase.AddGroup(_modFullTitle) as UIHelper;
            var mainGroupPanel = mainGroupHelper.self as UIPanel;
            mainGroupPanel.backgroundSprite = null;

            var modDropDown = mainGroupHelper.AddDropdown("Mod", relevantSortedModNames.ToArray(), 0, (index) => ShowModPanel(index)) as UIDropDown;
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

                _modPanels[i] = modPanel;

                if (relevantSortedModNames[i] != "Custom")
                {
                    var modNetInfoGroupViewReadModel = _netInfoGroupViewReadModel
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

                            var netGroupDemolishButton = netInfoGroupHelper.AddButton("Demolish", () => _gameEngineService.DemolishSegmentGroup(netInfoGroupViewReadModel)) as UIButton;
                            netGroupDemolishButton.textHorizontalAlignment = UIHorizontalAlignment.Center;
                            netGroupDemolishButton.relativePosition = new Vector3(netInfoGroupPanel.width - netGroupDemolishButton.width, 0);

                            var netGroupColorizeButton = netInfoGroupHelper.AddButton("Colorize", () => _gameEngineService.ColorizeSegmentGroup(netInfoGroupViewReadModel)) as UIButton;
                            netGroupColorizeButton.textHorizontalAlignment = UIHorizontalAlignment.Center;
                            netGroupColorizeButton.relativePosition = new Vector3(netInfoGroupPanel.width - netGroupDemolishButton.width - netGroupColorizeButton.width - 5f, 0);

                            if (netInfoGroupViewReadModel.HasAnyReplacements)
                            {
                                var netGroupReplaceButton = netInfoGroupHelper.AddButton("Replace", () => _gameEngineService.UpgradeSegmentGroup(netInfoGroupViewReadModel)) as UIButton;
                                netGroupReplaceButton.tooltip = "with " + netInfoGroupViewReadModel.DisplayNameReplacement;
                                netGroupReplaceButton.textHorizontalAlignment = UIHorizontalAlignment.Center;
                                netGroupReplaceButton.relativePosition = new Vector3(netInfoGroupPanel.width - netGroupDemolishButton.width - netGroupColorizeButton.width - netGroupReplaceButton.width - 10f, 0);
                            }
                        }

                        modPanel.autoFitChildrenVertically = true;
                        modPanel.autoLayoutDirection = LayoutDirection.Vertical;
                        modPanel.autoLayout = true;
                    }
                }
                else
                {
                    modPanel.autoLayout = false;

                    var targetTextField = modPanelHelper.AddTextfield("Target", string.Empty, (value) => { }, (value) => { }) as UITextField;
                    var targetTextFieldPanel = targetTextField.parent as UIPanel;
                    targetTextFieldPanel.relativePosition = new Vector3(0f, 0f);

                    var netGroupDemolishButton = modPanelHelper.AddButton("Demolish", () => _gameEngineService.DemolishSegment(targetTextField.text)) as UIButton;
                    netGroupDemolishButton.textHorizontalAlignment = UIHorizontalAlignment.Center;
                    netGroupDemolishButton.relativePosition = new Vector3(modPanel.width - netGroupDemolishButton.width, 20f);

                    var netGroupColorizeButton = modPanelHelper.AddButton("Colorize", () => _gameEngineService.ColorizeSegment(targetTextField.text)) as UIButton;
                    netGroupColorizeButton.textHorizontalAlignment = UIHorizontalAlignment.Center;
                    netGroupColorizeButton.relativePosition = new Vector3(modPanel.width - netGroupDemolishButton.width - netGroupColorizeButton.width - 5f, 20f);

                    var replacementTextField = modPanelHelper.AddTextfield("Replacement", string.Empty, (value) => { }, (value) => { }) as UITextField;
                    var replacementTextFieldPanel = replacementTextField.parent as UIPanel;
                    replacementTextFieldPanel.relativePosition = new Vector3(0f, 59f);

                    var netGroupReplaceButton = modPanelHelper.AddButton("Replace", () => _gameEngineService.UpgradeSegment(targetTextField.text, replacementTextField.text)) as UIButton;
                    netGroupReplaceButton.tooltip = "Replace Target with Replacement.";
                    netGroupReplaceButton.textHorizontalAlignment = UIHorizontalAlignment.Center;
                    netGroupReplaceButton.relativePosition = new Vector3(modPanel.width - netGroupReplaceButton.width, 79f);
                }
            }

            ShowModPanel(0); //select first element
        }
    }
}
