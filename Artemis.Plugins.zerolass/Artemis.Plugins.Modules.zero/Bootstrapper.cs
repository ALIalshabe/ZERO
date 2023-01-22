using Artemis.Core;
using Artemis.Core.Services;
using Artemis.UI.Shared;

namespace Artemis.Plugins.Modules.zero;

public class Bootstrapper : PluginBootstrapper
{
  
    public override void OnPluginEnabled(Plugin plugin)
    {
        INodeService _nodeService = plugin.Get<INodeService>();
            _nodeService.RegisterNodeType(plugin, typeof(zeroDataModel));
    }
    
}
