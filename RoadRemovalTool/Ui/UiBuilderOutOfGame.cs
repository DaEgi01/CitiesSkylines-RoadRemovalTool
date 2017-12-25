using ColossalFramework.UI;
using ICities;
using RoadRemovalTool.Model;
using System;

namespace RoadRemovalTool.Ui
{
    public class UiBuilderOutOfGame : IUiBuilder
    {
        private readonly UIHelperBase uIHelperBase;
        private readonly ModFullTitle modFullTitle;

        public UiBuilderOutOfGame(UIHelperBase uIHelperBase, ModFullTitle modFullTitle)
        {
            this.uIHelperBase = uIHelperBase ?? throw new ArgumentNullException(nameof(uIHelperBase));
            this.modFullTitle = modFullTitle ?? throw new ArgumentNullException(nameof(modFullTitle));
        }

        public void BuildUi()
        {
            var mainGroupUiHelper = this.uIHelperBase.AddGroup(this.modFullTitle) as UIHelper;

            var mainPanel = mainGroupUiHelper.self as UIPanel;
            var mainLabel = mainPanel.AddUIComponent<UILabel>();
            mainLabel.text = "This mod can only be used during gameplay.";
        }
    }
}
