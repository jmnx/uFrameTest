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
    
    
    public partial class DebugSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<Orc> _OrcManager;
        
        private IEcsComponentManagerOf<TestComponentNode> _TestComponentNodeManager;
        
        private IEcsComponentManagerOf<SwordComp> _SwordCompManager;
        
        private IEcsComponentManagerOf<HealthComp> _HealthCompManager;
        
        private IEcsComponentManagerOf<ShieldComp> _ShieldCompManager;
        
        private IEcsComponentManagerOf<edText> _edTextManager;
        
        private DebugSystemclickedHandler DebugSystemclickedHandlerInstance = new DebugSystemclickedHandler();
        
        private DebugSystemGameReadyHandler DebugSystemGameReadyHandlerInstance = new DebugSystemGameReadyHandler();
        
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
            this.OnEvent<test.clicked>().Subscribe(_=>{ DebugSystemclickedFilter(_); }).DisposeWith(this);
            this.OnEvent<uFrame.Kernel.GameReadyEvent>().Subscribe(_=>{ DebugSystemGameReadyFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void DebugSystemclickedHandler(test.clicked data) {
            var handler = DebugSystemclickedHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.Execute();
        }
        
        protected void DebugSystemclickedFilter(test.clicked data) {
            this.DebugSystemclickedHandler(data);
        }
        
        protected virtual void DebugSystemGameReadyHandler(uFrame.Kernel.GameReadyEvent data) {
            var handler = DebugSystemGameReadyHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.Execute();
        }
        
        protected void DebugSystemGameReadyFilter(uFrame.Kernel.GameReadyEvent data) {
            this.DebugSystemGameReadyHandler(data);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("81eb1603-b85d-4aaf-80c9-903965188281")]
    public partial class DebugSystem : DebugSystemBase {
        
        private static DebugSystem _Instance;
        
        public DebugSystem() {
            Instance = this;
        }
        
        public static DebugSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}