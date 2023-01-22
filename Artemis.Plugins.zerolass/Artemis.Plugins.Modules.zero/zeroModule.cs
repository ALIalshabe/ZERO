using System.Collections.Generic;
using Artemis.Core;
using Artemis.Core.Modules;
using Artemis.Plugins.Modules.zero.DataModels;

namespace Artemis.Plugins.Modules.zero;

public class zeroModule : Module<zeroDataModel>
{
        public override List<IModuleActivationRequirement> ActivationRequirements { get; } = new();

        public override void ModuleActivated(bool isOverride)
        {

        }

        public override void ModuleDeactivated(bool isOverride)
        {

        }

        public override void Enable() 
        { 

        }

        public override void Disable() 
        { 

        }

        public override void Update(double deltaTime) 
        { 

        }
}