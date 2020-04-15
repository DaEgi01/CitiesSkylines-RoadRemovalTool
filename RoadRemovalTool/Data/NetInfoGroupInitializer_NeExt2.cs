using RoadRemovalTool.Model;
using System.Collections.Generic;

namespace RoadRemovalTool.Data
{
    public class NetInfoGroupInitializer_NeExt2 : INetInfoGroupInitializer
    {
        private readonly bool _afterDarkDlcInstalled;
        private readonly bool _inMotionDlcInstalled;

        public NetInfoGroupInitializer_NeExt2(bool afterDarkDlcInstalled, bool inMotionDlcInstalled)
        {
            _afterDarkDlcInstalled = afterDarkDlcInstalled;
            _inMotionDlcInstalled = inMotionDlcInstalled;
        }
        
        public string ModName => "Network Extensions 2";

        public List<NetInfoGroup> Create()
        {
            return new List<NetInfoGroup>()
            {
                new NetInfoGroup(ModName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Tiny Cul-De-Sac"),
                    new NetInfoDemolishAndReplacementModel("Tiny Cul-De-Sac Bridge"),
                    new NetInfoDemolishAndReplacementModel("Tiny Cul-De-Sac Elevated"),
                    new NetInfoDemolishAndReplacementModel("Tiny Cul-De-Sac Slope"),
                    new NetInfoDemolishAndReplacementModel("Tiny Cul-De-Sac Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Two-Lane Alley")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("PlainStreet2L", "Basic Road")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway"),
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway With Parking")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Small, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Bridge", "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Decoration Grass", "Basic Road Decoration Grass"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Decoration Trees", "Basic Road Decoration Trees"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Elevated", "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Slope", "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Tunnel", "Basic Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Small, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("BasicRoadPntMdn", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadPntMdn Bridge", "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadPntMdn Elevated", "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadPntMdn Slope", "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadPntMdn Tunnel", "Basic Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Small, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Oneway with bicycle lanes", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("Oneway with bicycle lanes Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Oneway with bicycle lanes Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Oneway with bicycle lanes Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Oneway with bicycle lanes Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R3", _inMotionDlcInstalled ? "Asymmetrical Three Lane Road" : "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R3 Bridge", _inMotionDlcInstalled ? "Asymmetrical Three Lane Road Bridge" : "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R3 Elevated", _inMotionDlcInstalled ? "Asymmetrical Three Lane Road Elevated" : "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R3 Slope", _inMotionDlcInstalled ? "Asymmetrical Three Lane Road Slope" : "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R3 Tunnel", _inMotionDlcInstalled ? "Asymmetrical Three Lane Road Tunnel" : "Basic Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Small Avenue", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("Small Avenue Bridge", "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Small Avenue Elevated", "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Small Avenue Slope", "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Small Avenue Tunnel", "Basic Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.SmallHeavy, _inMotionDlcInstalled, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R2", _inMotionDlcInstalled ? "Asymmetrical Three Lane Road" : "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R2 Bridge", _inMotionDlcInstalled ? "Asymmetrical Three Lane Road Bridge" : "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R2 Elevated", _inMotionDlcInstalled ? "Asymmetrical Three Lane Road Elevated" : "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R2 Slope", _inMotionDlcInstalled ? "Asymmetrical Three Lane Road Slope" : "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R2 Tunnel", _inMotionDlcInstalled ? "Asymmetrical Three Lane Road Tunnel": "Basic Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("BasicRoadTL", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadTL Bridge",  "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadTL Elevated",  "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadTL Slope", "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadTL Tunnel", "Basic Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Oneway3L", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("Oneway3L Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Oneway3L Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Oneway3L Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Oneway3L Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Oneway4L", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("Oneway4L Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Oneway4L Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Oneway4L Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Oneway4L Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Medium, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R4", "Medium Road"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R4 Bridge", "Medium Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R4 Elevated", "Medium Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R4 Slope", "Medium Road Slope"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R4 Tunnel", "Medium Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Medium, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R3", "Medium Road"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R3 Bridge", "Medium Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R3 Elevated", "Medium Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R3 Slope", "Medium Road Slope"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R3 Tunnel", "Medium Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Medium, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Medium Avenue", "Medium Road"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue Bridge", "Medium Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue Elevated", "Medium Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue Slope", "Medium Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue Tunnel", "Medium Road Tunnel"),
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Medium, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Medium Avenue TL", "Medium Road"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue TL Bridge", "Medium Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue TL Elevated", "Medium Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue TL Slope", "Medium Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue TL Tunnel", "Medium Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Large, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Six-Lane Avenue Median", "Large Road"),
                    new NetInfoDemolishAndReplacementModel("Six-Lane Avenue Median Bridge", "Large Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Six-Lane Avenue Median Elevated", "Large Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Six-Lane Avenue Median Slope", "Large Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Six-Lane Avenue Median Tunnel",  "Large Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Large, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Eight-Lane Avenue", "Large Road"),
                    new NetInfoDemolishAndReplacementModel("Eight-Lane Avenue Bridge", "Large Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Eight-Lane Avenue Elevated", "Large Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Eight-Lane Avenue Slope", "Large Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Eight-Lane Avenue Tunnel",  "Large Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Highway, _inMotionDlcInstalled, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Four-Lane Highway", _inMotionDlcInstalled ? "Four Lane Highway" : "Highway"),
                    new NetInfoDemolishAndReplacementModel("Four-Lane Highway Bridge", _inMotionDlcInstalled ? "Four Lane Highway Bridge" : "Highway Bridge"),
                    new NetInfoDemolishAndReplacementModel("Four-Lane Highway Elevated", _inMotionDlcInstalled ? "Four Lane Highway Elevated" : "Highway Elevated"),
                    new NetInfoDemolishAndReplacementModel("Four-Lane Highway Slope", _inMotionDlcInstalled ? "Four Lane Highway Slope" : "Highway Slope"),
                    new NetInfoDemolishAndReplacementModel("Four-Lane Highway Tunnel", _inMotionDlcInstalled ? "Four Lane Highway Tunnel" : "Highway Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Highway, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Five-Lane Highway", _inMotionDlcInstalled ? "Four Lane Highway" : "Highway"),
                    new NetInfoDemolishAndReplacementModel("Five-Lane Highway Bridge", _inMotionDlcInstalled ? "Four Lane Highway Bridge" : "Highway Bridge"),
                    new NetInfoDemolishAndReplacementModel("Five-Lane Highway Elevated", _inMotionDlcInstalled ? "Four Lane Highway Elevated" : "Highway Elevated"),
                    new NetInfoDemolishAndReplacementModel("Five-Lane Highway Slope", _inMotionDlcInstalled ? "Four Lane Highway Slope" : "Highway Slope"),
                    new NetInfoDemolishAndReplacementModel("Five-Lane Highway Tunnel", _inMotionDlcInstalled ? "Four Lane Highway Tunnel" : "Highway Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Highway, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Large Highway", _inMotionDlcInstalled ? "Four Lane Highway" : "Highway"),
                    new NetInfoDemolishAndReplacementModel("Large Highway Bridge", _inMotionDlcInstalled ? "Four Lane Highway Bridge" : "Highway Bridge"),
                    new NetInfoDemolishAndReplacementModel("Large Highway Elevated", _inMotionDlcInstalled ? "Four Lane Highway Elevated" : "Highway Elevated"),
                    new NetInfoDemolishAndReplacementModel("Large Highway Slope", _inMotionDlcInstalled ? "Four Lane Highway Slope" : "Highway Slope"),
                    new NetInfoDemolishAndReplacementModel("Large Highway Tunnel", _inMotionDlcInstalled ? "Four Lane Highway Tunnel" : "Highway Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Highway, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("AsymHighwayL1R2"),
                    new NetInfoDemolishAndReplacementModel("AsymHighwayL1R2 Bridge"),
                    new NetInfoDemolishAndReplacementModel("AsymHighwayL1R2 Elevated"),
                    new NetInfoDemolishAndReplacementModel("AsymHighwayL1R2 Slope"),
                    new NetInfoDemolishAndReplacementModel("AsymHighwayL1R2 Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Highway, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Highway2L2W"),
                    new NetInfoDemolishAndReplacementModel("Highway2L2W Bridge"),
                    new NetInfoDemolishAndReplacementModel("Highway2L2W Elevated"),
                    new NetInfoDemolishAndReplacementModel("Highway2L2W Slope"),
                    new NetInfoDemolishAndReplacementModel("Highway2L2W Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Highway, _inMotionDlcInstalled, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Small Rural Highway", _inMotionDlcInstalled ? "Two Lane Highway Twoway" : "Highway"),
                    new NetInfoDemolishAndReplacementModel("Small Rural Highway Bridge", _inMotionDlcInstalled ? "Two Lane Highway Twoway Bridge" : "Highway Bridge"),
                    new NetInfoDemolishAndReplacementModel("Small Rural Highway Elevated", _inMotionDlcInstalled ? "Two Lane Highway Twoway Elevated" : "Highway Elevated"),
                    new NetInfoDemolishAndReplacementModel("Small Rural Highway Slope", _inMotionDlcInstalled ? "Two Lane Highway Twoway Slope" : "Highway Slope"),
                    new NetInfoDemolishAndReplacementModel("Small Rural Highway Tunnel", _inMotionDlcInstalled ? "Two Lane Highway Twoway Tunnel" : "Highway Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Highway, _inMotionDlcInstalled, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Rural Highway", _inMotionDlcInstalled ? "Two Lane Highway" : "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("Rural Highway Bridge", _inMotionDlcInstalled ? "Two Lane Highway Bridge" : "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Rural Highway Elevated", _inMotionDlcInstalled ? "Two Lane Highway Elevated" : "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Rural Highway Slope", _inMotionDlcInstalled ? "Two Lane Highway Slope" : "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Rural Highway Tunnel", _inMotionDlcInstalled ? "Two Lane Highway Tunnel" : "Basic Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Bus, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Small Busway", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Bridge", "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Decoration Grass", "Basic Road Decoration Grass"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Decoration Trees", "Basic Road Decoration Trees"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Elevated", "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Slope", "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Tunnel", "Basic Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Bus, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Decoration Grass", "Oneway Road Decoration Grass"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Decoration Trees", "Oneway Road Decoration Trees"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Bus, _afterDarkDlcInstalled, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Large Road With Bus Lanes", _afterDarkDlcInstalled ? "Large Road Bus" : "Large Road"),
                    new NetInfoDemolishAndReplacementModel("Large Road Bridge With Bus Lanes", _afterDarkDlcInstalled ? "Large Road Bridge Bus" : "Large Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Large Road Decoration Grass With Bus Lanes", _afterDarkDlcInstalled ? "Large Road Bus" : "Large Road Decoration Grass"),
                    new NetInfoDemolishAndReplacementModel("Large Road Decoration Trees With Bus Lanes", _afterDarkDlcInstalled ? "Large Road Bus" : "Large Road Decoration Trees"),
                    new NetInfoDemolishAndReplacementModel("Large Road Elevated With Bus Lanes", _afterDarkDlcInstalled ? "Large Road Elevated Bus" : "Large Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Large Road Slope With Bus Lanes", _afterDarkDlcInstalled ? "Large Road Slope Bus" : "Large Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Large Road Tunnel With Bus Lanes", _afterDarkDlcInstalled ? "Large Road Tunnel Bus" : "Large Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Boardwalk Tiny"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Boardwalk Tiny Elevated")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Pavement"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Elevated")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Pavement Tiny"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Pavement Tiny Elevated")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Gravel", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Gravel Elevated", "Basic Road Elevated")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Gravel Tiny"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Gravel Tiny Elevated")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Stone Tiny Road"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Stone Tiny Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Stone Tiny Road Elevated")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Promenade", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("Zonable Promenade Elevated", "Basic Road Elevated")
                })
            };
        }
    }
}
