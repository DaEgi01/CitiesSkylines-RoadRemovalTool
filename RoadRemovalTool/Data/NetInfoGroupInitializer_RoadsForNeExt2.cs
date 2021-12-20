using RoadRemovalTool.Model;
using System.Collections.Generic;

namespace RoadRemovalTool.Data
{
    public class NetInfoGroupInitializer_RoadsForNeExt2 : INetInfoGroupInitializer
    {
        public string ModName => "Roads For NeExt 2";

        public List<NetInfoGroup> Create()
        {
            return new List<NetInfoGroup>()
            {
                new NetInfoGroup(ModName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("Two-Lane Oneway")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway With Parking and Bicycle lane"),
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Tiny, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway With Two Bicycle Lanes"),
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Small, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway with bicycle lanes and parking", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway with bicycle lanes and parking Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway with bicycle lanes and parking Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway with bicycle lanes and parking Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("One-Lane Oneway with bicycle lanes and parking Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("OneWay3LBike", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LBike Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LBike Decoration Grass", "Oneway Road Decoration Grass"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LBike Decoration Trees", "Oneway Road Decoration Trees"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LBike Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LBike Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LBike Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("OneWay3LBikeAndBus", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LBikeAndBus Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LBikeAndBus Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LBikeAndBus Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LBikeAndBus Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.SmallHeavy, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("OneWay3LParking", "Oneway Road"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LParking Bridge", "Oneway Road Bridge"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LParking Elevated", "Oneway Road Elevated"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LParking Slope", "Oneway Road Slope"),
                    new NetInfoDemolishAndReplacementModel("OneWay3LParking Tunnel", "Oneway Road Tunnel")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Medium, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("FourDevidedLaneAvenue4Parking", "Medium Road"),
                    new NetInfoDemolishAndReplacementModel("FourDevidedLaneAvenue4Parking Decoration Grass", "Medium Road Decoration Grass"),
                    new NetInfoDemolishAndReplacementModel("FourDevidedLaneAvenue4Parking Decoration Trees", "Medium Road Decoration Trees")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Medium, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("FourDevidedLaneAvenue2Bus", "Large Road Bus"),
                    new NetInfoDemolishAndReplacementModel("FourDevidedLaneAvenue2Bus Decoration Grass", "Large Road Bus"),
                    new NetInfoDemolishAndReplacementModel("FourDevidedLaneAvenue2Bus Decoration Trees", "Large Road Bus")
                }),
                new NetInfoGroup(ModName, RoadUiCategory.Large, false, new List<NetInfoDemolishAndReplacementModel>() {
                    new NetInfoDemolishAndReplacementModel("WideAvenue6LBusCenterBike", "Large Road Bus"),
                    new NetInfoDemolishAndReplacementModel("WideAvenue6LBusCenterBike Decoration Grass", "Large Road Bus"),
                    new NetInfoDemolishAndReplacementModel("WideAvenue6LBusCenterBike Decoration Trees", "Large Road Bus"),
                }),
            };
        }
    }
}
