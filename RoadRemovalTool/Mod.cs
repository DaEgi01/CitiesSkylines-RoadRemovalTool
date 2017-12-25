using ColossalFramework;
using ICities;
using RoadRemovalTool.Data;
using RoadRemovalTool.Model;
using RoadRemovalTool.Services;
using RoadRemovalTool.Ui;
using System.Linq;

namespace RoadRemovalTool
{
    public class Mod : LoadingExtensionBase, IUserMod
    {
        private bool onCreatedInvoked = false;

        public string Name => "Road Removal Tool";
        public string Description => "Automatically demolishes specific mod roads or replaces them with Colossal Order roads.";
        public string Version => "1.0.0";

        public override void OnCreated(ILoading loading)
        {
            this.onCreatedInvoked = true;
        }

        public void OnSettingsUI(UIHelperBase helper)
        {
            var modFullTitle = new ModFullTitle(this.Name, this.Version);

            IUiBuilder uiBuilder;

            if (this.onCreatedInvoked)
            {
                this.onCreatedInvoked = false;

                var coverageManager = Singleton<CoverageManager>.instance;
                var netManager = Singleton<NetManager>.instance;
                var simulationManager = Singleton<SimulationManager>.instance;
                var gameEngineService = new GameEngineService(coverageManager, netManager, simulationManager);

                var netInfoGroupsMOM = new NetInfoGroupInitializer_MOM(); //TODO improve MOM support
                var netInfoGroupsNeExt2 = new NetInfoGroupInitializer_NeExt2();
                var netInfoGroupsRoadsForNeExt2 = new NetInfoGroupInitializer_RoadsForNeExt2();
                //TODO one-way train tracks
                //TODO Ronyx Highway

                var netInfoGroups = netInfoGroupsMOM.Create()
                    .Concat(netInfoGroupsNeExt2.Create())
                    .Concat(netInfoGroupsRoadsForNeExt2.Create());

                var netInfoGroupViewReadModelFactory = new NetInfoGroupViewReadModelFactory();
                var netInfoGroupViewReadModels = netInfoGroups.Select(x => netInfoGroupViewReadModelFactory.Create(x)).ToList();

                uiBuilder = new UiBuilderInGame(helper, modFullTitle, gameEngineService, netInfoGroupViewReadModels);
            }
            else
            {
                uiBuilder = new UiBuilderOutOfGame(helper, modFullTitle);
            }

            uiBuilder.BuildUi();
        }
    }
}
