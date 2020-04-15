using RoadRemovalTool.Model;
using System.Collections.Generic;

namespace RoadRemovalTool.Data
{
    public class NetInfoGroupInitializer_MOM : INetInfoGroupInitializer
    {
        public string ModName => "Metro Overhaul Mod";

        //TODO add demolish of metrostations or buildings in general
        
        public List<NetInfoGroup> Create()
        {
            return new List<NetInfoGroup>()
            {
                new NetInfoGroup(ModName, RoadUiCategory.Metro, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Metro Track Bridge"),
                    new NetInfoDemolishAndReplacementModel("Metro Track Bridge NoBar"),
                    new NetInfoDemolishAndReplacementModel("Metro Track Elevated"),
                    new NetInfoDemolishAndReplacementModel("Metro Track Elevated NoBar"),
                    new NetInfoDemolishAndReplacementModel("Metro Track Ground"),
                    new NetInfoDemolishAndReplacementModel("Metro Track Ground NoBar"),
                    new NetInfoDemolishAndReplacementModel("Metro Track Slope"),
                    new NetInfoDemolishAndReplacementModel("Metro Station Track Elevated"),
                    new NetInfoDemolishAndReplacementModel("Metro Station Track Ground"),
                    new NetInfoDemolishAndReplacementModel("Metro Station Track Sunken"),
                    new NetInfoDemolishAndReplacementModel("Metro Station Track Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Metro, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Steel Metro Track Bridge"),
                    new NetInfoDemolishAndReplacementModel("Steel Metro Track Bridge NoBar"),
                    new NetInfoDemolishAndReplacementModel("Steel Metro Track Elevated"),
                    new NetInfoDemolishAndReplacementModel("Steel Metro Track Elevated NoBar"),
                    new NetInfoDemolishAndReplacementModel("Steel Metro Track Ground"),
                    new NetInfoDemolishAndReplacementModel("Steel Metro Track Ground NoBar"),
                    new NetInfoDemolishAndReplacementModel("Steel Metro Station Track Elevated"),
                    new NetInfoDemolishAndReplacementModel("Steel Metro Station Track Ground"),
                    new NetInfoDemolishAndReplacementModel("Steel Metro Station Track Sunken"),
                    new NetInfoDemolishAndReplacementModel("Steel Metro Station Track Tunnel")
                })
            };
        }
    }
}
