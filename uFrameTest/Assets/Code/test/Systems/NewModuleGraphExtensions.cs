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
    
    
    #region 
static
    public class NewModuleGraphExtensions {
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<SwordComp> SwordCompManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<SwordComp>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<HealthComp> HealthCompManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<HealthComp>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<TestComponentNode> TestComponentNodeManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<TestComponentNode>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<ShieldComp> ShieldCompManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<ShieldComp>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<edText> edTextManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<edText>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<Orc> OrcManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Orc>();
        }
        #endregion
        
        #region 
static
        public List<SwordComp> SwordCompComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<SwordComp>().Components;
        }
        #endregion
        
        #region 
static
        public List<HealthComp> HealthCompComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<HealthComp>().Components;
        }
        #endregion
        
        #region 
static
        public List<TestComponentNode> TestComponentNodeComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<TestComponentNode>().Components;
        }
        #endregion
        
        #region 
static
        public List<ShieldComp> ShieldCompComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<ShieldComp>().Components;
        }
        #endregion
        
        #region 
static
        public List<edText> edTextComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<edText>().Components;
        }
        #endregion
        
        #region 
static
        public List<Orc> OrcComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Orc>().Components;
        }
        #endregion
    }
    #endregion
}
