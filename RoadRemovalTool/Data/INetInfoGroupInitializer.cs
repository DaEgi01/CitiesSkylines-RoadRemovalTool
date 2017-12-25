using RoadRemovalTool.Model;
using System.Collections.Generic;

namespace RoadRemovalTool.Data
{
    public interface INetInfoGroupInitializer
    {
        List<NetInfoGroup> Create();
    }
}
