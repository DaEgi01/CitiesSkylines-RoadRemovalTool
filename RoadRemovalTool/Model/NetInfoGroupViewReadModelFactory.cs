using System.Collections.Generic;

namespace RoadRemovalTool.Model
{
    public class NetInfoGroupViewReadModelFactory
    {
        private readonly Dictionary<string, string> nameCache = new Dictionary<string, string>();

        public NetInfoGroupViewReadModel Create(NetInfoGroup netInfoGroup)
        {
            var displayNameOriginal = GetCachedDisplayName(netInfoGroup.SystemNameOriginal);            
            if (displayNameOriginal == null)
            {
                return new NetInfoGroupViewReadModel(netInfoGroup, false);
            }

            if (netInfoGroup.SystemNameReplacement == null)
            {
                return new NetInfoGroupViewReadModel(netInfoGroup, true, displayNameOriginal);
            }

            var titleReplacement = GetCachedDisplayName(netInfoGroup.SystemNameReplacement);
            return new NetInfoGroupViewReadModel(netInfoGroup, true, displayNameOriginal, titleReplacement);
        }

        private string GetCachedDisplayName(string systemName)
        {
            var titleIsCached = nameCache.TryGetValue(systemName, out string displayName);
            if (!titleIsCached)
            {
                var netInfo = PrefabCollection<NetInfo>.FindLoaded(systemName);
                displayName = netInfo?.GetUncheckedLocalizedTitle();
                nameCache.Add(systemName, displayName);
            }

            return displayName;
        }
    }
}
