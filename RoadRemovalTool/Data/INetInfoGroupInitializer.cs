using RoadRemovalTool.Model;
using System.Collections.Generic;

namespace RoadRemovalTool.Data
{
    public interface INetInfoGroupInitializer
    {
        string ModName { get; }

        List<NetInfoGroup> Create();
    }
}
