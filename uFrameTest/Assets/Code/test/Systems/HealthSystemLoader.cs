// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace test {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.ECS.UnityUtilities;
    using uFrame.Kernel;
    
    
    [uFrame.Attributes.uFrameIdentifier("5d2ff56f-35bb-401d-a5a9-5b38793e2e12")]
    public partial class HealthSystemLoader : uFrame.Kernel.SystemLoader {
        
        public override void Load() {
            this.AddSystem<HealthSystem>();
        }
    }
}
