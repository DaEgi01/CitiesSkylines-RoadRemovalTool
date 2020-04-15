using System;

namespace RoadRemovalTool.Model
{
    /// <summary>
    /// Contains the information that is necessary to decide what NetInfos are part of a NetInfoGroup and if NetInfos can be demolished or replaced.
    /// </summary>
    public class NetInfoDemolishAndReplacementModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="netInfoSystemName">This is what will be demolished.</param>
        /// <param name="netInfoSystemNameReplacement">This is the replacement target. It is optional and if it is null, it is assumed that this NetInfo can't be replaced.</param>
        public NetInfoDemolishAndReplacementModel(string netInfoSystemName, string netInfoSystemNameReplacement = null)
        {
            SystemNameOriginal = netInfoSystemName ?? throw new ArgumentNullException(nameof(netInfoSystemName));
            SystemNameReplacement = netInfoSystemNameReplacement; //is optional since not all NetSegments can be replaced without sideeffects
        }

        public string SystemNameOriginal { get; }
        public string SystemNameReplacement { get; }
        public bool HasReplacement => SystemNameReplacement != null;
    }
}
