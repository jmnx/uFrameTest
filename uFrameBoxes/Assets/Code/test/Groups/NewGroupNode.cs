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
    using uFrame.Kernel;
    using UniRx;
    
    
    [uFrame.Attributes.ComponentId(1)]
    public partial class NewGroupNode : uFrame.ECS.Components.GroupItem {
        
        private playerComp _playerComp;
        
        private healthComp _healthComp;
        
        public playerComp playerComp {
            get {
                return _playerComp;
            }
            set {
                _playerComp = value;
            }
        }
        
        public healthComp healthComp {
            get {
                return _healthComp;
            }
            set {
                _healthComp = value;
            }
        }
        
        public override int ComponentId {
            get {
                return 1;
            }
        }
    }
}
