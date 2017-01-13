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
    using test;
    using uFrame.ECS.APIs;
    using uFrame.ECS.Components;
    using uFrame.ECS.Systems;
    using uFrame.Kernel;
    using UniRx;
    using UnityEngine;
    
    
    public partial class createObjectSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<Orc> _OrcManager;
        
        private IEcsComponentManagerOf<TestComponentNode> _TestComponentNodeManager;
        
        private IEcsComponentManagerOf<SwordComp> _SwordCompManager;
        
        private IEcsComponentManagerOf<HealthComp> _HealthCompManager;
        
        private IEcsComponentManagerOf<ShieldComp> _ShieldCompManager;
        
        private IEcsComponentManagerOf<edText> _edTextManager;
        
        public IEcsComponentManagerOf<Orc> OrcManager {
            get {
                return _OrcManager;
            }
            set {
                _OrcManager = value;
            }
        }
        
        public IEcsComponentManagerOf<TestComponentNode> TestComponentNodeManager {
            get {
                return _TestComponentNodeManager;
            }
            set {
                _TestComponentNodeManager = value;
            }
        }
        
        public IEcsComponentManagerOf<SwordComp> SwordCompManager {
            get {
                return _SwordCompManager;
            }
            set {
                _SwordCompManager = value;
            }
        }
        
        public IEcsComponentManagerOf<HealthComp> HealthCompManager {
            get {
                return _HealthCompManager;
            }
            set {
                _HealthCompManager = value;
            }
        }
        
        public IEcsComponentManagerOf<ShieldComp> ShieldCompManager {
            get {
                return _ShieldCompManager;
            }
            set {
                _ShieldCompManager = value;
            }
        }
        
        public IEcsComponentManagerOf<edText> edTextManager {
            get {
                return _edTextManager;
            }
            set {
                _edTextManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            OrcManager = ComponentSystem.RegisterGroup<OrcGroup,Orc>();
            TestComponentNodeManager = ComponentSystem.RegisterComponent<TestComponentNode>(1);
            SwordCompManager = ComponentSystem.RegisterComponent<SwordComp>(4);
            HealthCompManager = ComponentSystem.RegisterComponent<HealthComp>(2);
            ShieldCompManager = ComponentSystem.RegisterComponent<ShieldComp>(3);
            edTextManager = ComponentSystem.RegisterComponent<edText>(6);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("1a9c6044-cb7b-4ed7-b2eb-1e26fe83f1a7")]
    public partial class createObjectSystem : createObjectSystemBase {
        
        private static createObjectSystem _Instance;
        
        public createObjectSystem() {
            Instance = this;
        }
        
        public static createObjectSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
