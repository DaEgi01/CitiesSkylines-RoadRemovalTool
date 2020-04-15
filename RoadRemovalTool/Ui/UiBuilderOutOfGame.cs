using ColossalFramework.UI;
using ICities;
using RoadRemovalTool.Model;
using System;

namespace RoadRemovalTool.Ui
{
    public class UiBuilderOutOfGame : IUiBuilder
    {
        private readonly UIHelperBase _uIHelperBase;
        private readonly ModFullTitle _modFullTitle;

        public UiBuilderOutOfGame(UIHelperBase uIHelperBase, ModFullTitle modFullTitle)
        {
            _uIHelperBase = uIHelperBase ?? throw new ArgumentNullException(nameof(uIHelperBase));
            _modFullTitle = modFullTitle ?? throw new ArgumentNullException(nameof(modFullTitle));
        }

        public void BuildUi()
        {
            var mainGroupUiHelper = _uIHelperBase.AddGroup(this._modFullTitle) as UIHelper;

            var mainPanel = mainGroupUiHelper.self as UIPanel;
            var mainLabel = mainPanel.AddUIComponent<UILabel>();
            mainLabel.text = "This mod can only be used during gameplay.";
        }
    }
}
