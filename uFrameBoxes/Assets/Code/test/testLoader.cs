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
    using uFrame.ECS.Systems;
    using uFrame.ECS.UnityUtilities;
    using uFrame.Kernel;
    
    
    public partial class testLoader : uFrame.Kernel.SystemLoader {
        
        public override void Load() {
            EcsSystem system = null;
            system = this.AddSystem<healthSys>();
            system = this.AddSystem<inpSys>();
        }
    }
}
