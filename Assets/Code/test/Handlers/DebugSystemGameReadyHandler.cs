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
    using UnityEngine;
    
    
    public class DebugSystemGameReadyHandler {
        
        private uFrame.Kernel.GameReadyEvent _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private object ActionNode2_message = default( System.Object );
        
        private string StringNode3 = "Game is Ready!";
        
        public uFrame.Kernel.GameReadyEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.Systems.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual void Execute() {
            ActionNode2_message = StringNode3;
            // ActionNode
            // Visit uFrame.ECS.Actions.DebugLibrary.LogMessage
            uFrame.ECS.Actions.DebugLibrary.LogMessage(ActionNode2_message);
        }
    }
}