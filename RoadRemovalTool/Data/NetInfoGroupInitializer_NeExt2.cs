using RoadRemovalTool.Model;
using System.Collections.Generic;

namespace RoadRemovalTool.Data
{
    public class NetInfoGroupInitializer_NeExt2 : INetInfoGroupInitializer
    {
        public readonly string modName = "Network Extensions 2";

        public List<NetInfoGroup> Create()
        {
            return new List<NetInfoGroup>()
            {
                new NetInfoGroup(modName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Tiny Cul-De-Sac"),
                    new NetInfoDemolishAndReplacementModel("Tiny Cul-De-Sac Bridge"),
                    new NetInfoDemolishAndReplacementModel("Tiny Cul-De-Sac Elevated"),
                    new NetInfoDemolishAndReplacementModel("Tiny Cul-De-Sac Slope"),
                    new NetInfoDemolishAndReplacementModel("Tiny Cul-De-Sac Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Two-Lane Alley")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("PlainStreet2L", "Basic Road")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway"),
                }),
                new NetInfoGroup(modName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway With Parking")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Small, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Bridge", "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Decoration Grass", "Basic Road Decoration Grass"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Decoration Trees", "Basic Road Decoration Trees"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Elevated", "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Slope", "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadMdn Tunnel", "Basic Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Small, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("BasicRoadPntMdn", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadPntMdn Bridge", "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadPntMdn Elevated", "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadPntMdn Slope", "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadPntMdn Tunnel", "Basic Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Small, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Oneway with bicycle lanes", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("Oneway with bicycle lanes Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Oneway with bicycle lanes Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Oneway with bicycle lanes Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Oneway with bicycle lanes Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R3", "Asymmetrical Three Lane Road"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R3 Bridge", "Asymmetrical Three Lane Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R3 Elevated", "Asymmetrical Three Lane Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R3 Slope", "Asymmetrical Three Lane Road Slope"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R3 Tunnel", "Asymmetrical Three Lane Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Small Avenue", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("Small Avenue Bridge", "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Small Avenue Elevated", "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Small Avenue Slope", "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Small Avenue Tunnel", "Basic Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.SmallHeavy, true, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R2", "Asymmetrical Three Lane Road"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R2 Bridge", "Asymmetrical Three Lane Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R2 Elevated", "Asymmetrical Three Lane Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R2 Slope", "Asymmetrical Three Lane Road Slope"),
                    new NetInfoDemolishAndReplacementModel("AsymRoadL1R2 Tunnel", "Asymmetrical Three Lane Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("BasicRoadTL", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadTL Bridge",  "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadTL Elevated",  "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadTL Slope", "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("BasicRoadTL Tunnel", "Basic Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Oneway3L", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("Oneway3L Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Oneway3L Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Oneway3L Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Oneway3L Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Oneway4L", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("Oneway4L Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Oneway4L Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Oneway4L Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Oneway4L Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Medium, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R4", "Medium Road"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R4 Bridge", "Medium Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R4 Elevated", "Medium Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R4 Slope", "Medium Road Slope"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R4 Tunnel", "Medium Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Medium, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R3", "Medium Road"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R3 Bridge", "Medium Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R3 Elevated", "Medium Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R3 Slope", "Medium Road Slope"),
                    new NetInfoDemolishAndReplacementModel("AsymAvenueL2R3 Tunnel", "Medium Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Medium, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Medium Avenue", "Medium Road"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue Bridge", "Medium Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue Elevated", "Medium Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue Slope", "Medium Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue Tunnel", "Medium Road Tunnel"),
                }),
                new NetInfoGroup(modName, RoadUiCategory.Medium, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Medium Avenue TL", "Medium Road"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue TL Bridge", "Medium Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue TL Elevated", "Medium Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue TL Slope", "Medium Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Medium Avenue TL Tunnel", "Medium Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Large, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Six-Lane Avenue Median", "Large Road"),
                    new NetInfoDemolishAndReplacementModel("Six-Lane Avenue Median Bridge", "Large Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Six-Lane Avenue Median Elevated", "Large Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Six-Lane Avenue Median Slope", "Large Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Six-Lane Avenue Median Tunnel",  "Large Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Large, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Eight-Lane Avenue", "Large Road"),
                    new NetInfoDemolishAndReplacementModel("Eight-Lane Avenue Bridge", "Large Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Eight-Lane Avenue Elevated", "Large Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Eight-Lane Avenue Slope", "Large Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Eight-Lane Avenue Tunnel",  "Large Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Highway, true, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Four-Lane Highway", "Four Lane Highway"),
                    new NetInfoDemolishAndReplacementModel("Four-Lane Highway Bridge", "Four Lane Highway Bridge"),
                    new NetInfoDemolishAndReplacementModel("Four-Lane Highway Elevated", "Four Lane Highway Elevated"),
                    new NetInfoDemolishAndReplacementModel("Four-Lane Highway Slope", "Four Lane Highway Slope"),
                    new NetInfoDemolishAndReplacementModel("Four-Lane Highway Tunnel", "Four Lane Highway Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Highway, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Five-Lane Highway", "Four Lane Highway"),
                    new NetInfoDemolishAndReplacementModel("Five-Lane Highway Bridge", "Four Lane Highway Bridge"),
                    new NetInfoDemolishAndReplacementModel("Five-Lane Highway Elevated", "Four Lane Highway Elevated"),
                    new NetInfoDemolishAndReplacementModel("Five-Lane Highway Slope", "Four Lane Highway Slope"),
                    new NetInfoDemolishAndReplacementModel("Five-Lane Highway Tunnel", "Four Lane Highway Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Highway, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Large Highway", "Four Lane Highway"),
                    new NetInfoDemolishAndReplacementModel("Large Highway Bridge", "Four Lane Highway Bridge"),
                    new NetInfoDemolishAndReplacementModel("Large Highway Elevated", "Four Lane Highway Elevated"),
                    new NetInfoDemolishAndReplacementModel("Large Highway Slope", "Four Lane Highway Slope"),
                    new NetInfoDemolishAndReplacementModel("Large Highway Tunnel", "Four Lane Highway Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Highway, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("AsymHighwayL1R2"),
                    new NetInfoDemolishAndReplacementModel("AsymHighwayL1R2 Bridge"),
                    new NetInfoDemolishAndReplacementModel("AsymHighwayL1R2 Elevated"),
                    new NetInfoDemolishAndReplacementModel("AsymHighwayL1R2 Slope"),
                    new NetInfoDemolishAndReplacementModel("AsymHighwayL1R2 Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Highway, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Highway2L2W"),
                    new NetInfoDemolishAndReplacementModel("Highway2L2W Bridge"),
                    new NetInfoDemolishAndReplacementModel("Highway2L2W Elevated"),
                    new NetInfoDemolishAndReplacementModel("Highway2L2W Slope"),
                    new NetInfoDemolishAndReplacementModel("Highway2L2W Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Highway, true, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Small Rural Highway", "Two Lane Highway Twoway"),
                    new NetInfoDemolishAndReplacementModel("Small Rural Highway Bridge", "Two Lane Highway Twoway Bridge"),
                    new NetInfoDemolishAndReplacementModel("Small Rural Highway Elevated", "Two Lane Highway Twoway Elevated"),
                    new NetInfoDemolishAndReplacementModel("Small Rural Highway Slope", "Two Lane Highway Twoway Slope"),
                    new NetInfoDemolishAndReplacementModel("Small Rural Highway Tunnel",  "Two Lane Highway Twoway Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Highway, true, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Rural Highway", "Two Lane Highway"),
                    new NetInfoDemolishAndReplacementModel("Rural Highway Bridge", "Two Lane Highway Bridge"),
                    new NetInfoDemolishAndReplacementModel("Rural Highway Elevated", "Two Lane Highway Elevated"),
                    new NetInfoDemolishAndReplacementModel("Rural Highway Slope", "Two Lane Highway Slope"),
                    new NetInfoDemolishAndReplacementModel("Rural Highway Tunnel", "Two Lane Highway Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Bus, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Small Busway", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Bridge", "Basic Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Decoration Grass", "Basic Road Decoration Grass"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Decoration Trees", "Basic Road Decoration Trees"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Elevated", "Basic Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Slope", "Basic Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Small Busway Tunnel", "Basic Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Bus, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Decoration Grass", "Oneway Road Decoration Grass"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Decoration Trees", "Oneway Road Decoration Trees"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("Small Busway OneWay Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Bus, true, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Large Road With Bus Lanes", "Large Road Bus"),
                    new NetInfoDemolishAndReplacementModel("Large Road Bridge With Bus Lanes", "Large Road Bridge Bus"),
                    new NetInfoDemolishAndReplacementModel("Large Road Decoration Grass With Bus Lanes", "Large Road Bus"),
                    new NetInfoDemolishAndReplacementModel("Large Road Decoration Trees With Bus Lanes", "Large Road Bus"),
                    new NetInfoDemolishAndReplacementModel("Large Road Elevated With Bus Lanes", "Large Road Elevated Bus"),
                    new NetInfoDemolishAndReplacementModel("Large Road Slope With Bus Lanes", "Large Road Slope Bus"),
                    new NetInfoDemolishAndReplacementModel("Large Road Tunnel With Bus Lanes", "Large Road Tunnel Bus")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Boardwalk Tiny"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Boardwalk Tiny Elevated")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Pavement"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Elevated")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Pavement Tiny"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Pavement Tiny Elevated")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Gravel", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Gravel Elevated", "Basic Road Elevated")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Gravel Tiny"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Gravel Tiny Elevated")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Stone Tiny Road"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Stone Tiny Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("Zonable Pedestrian Stone Tiny Road Elevated")
                }),
                new NetInfoGroup(modName, RoadUiCategory.Pedestrian, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Zonable Promenade", "Basic Road"),
                    new NetInfoDemolishAndReplacementModel("Zonable Promenade Elevated", "Basic Road Elevated")
                })
            };
        }
    }
}
