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
    using uFrame.ECS.APIs;
    using uFrame.ECS.Components;
    using uFrame.ECS.Systems;
    using uFrame.Kernel;
    using UniRx;
    
    
    public partial class NewGroupNodeGroup : ReactiveGroup<NewGroupNode> {
        
        private IEcsComponentManagerOf<meineTestComp> _meineTestCompManager;
        
        private int lastEntityId;
        
        private meineTestComp meineTestComp;
        
        public IEcsComponentManagerOf<meineTestComp> meineTestCompManager {
            get {
                return _meineTestCompManager;
            }
            set {
                _meineTestCompManager = value;
            }
        }
        
        public override System.Collections.Generic.IEnumerable<UniRx.IObservable<int>> Install(uFrame.ECS.APIs.IComponentSystem componentSystem) {
            meineTestCompManager = componentSystem.RegisterComponent<meineTestComp>();
            yield return meineTestCompManager.CreatedObservable.Select(_=>_.EntityId);;
            yield return meineTestCompManager.RemovedObservable.Select(_=>_.EntityId);;
        }
        
        public override bool Match(int entityId) {
            lastEntityId = entityId;
            if ((meineTestComp = meineTestCompManager[entityId]) == null) {
                return false;
            }
            return true;
        }
        
        public override NewGroupNode Select() {
            var item = new NewGroupNode();;
            item.EntityId = lastEntityId;
            item.meineTestComp = meineTestComp;
            return item;
        }
    }
}
