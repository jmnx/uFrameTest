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
    using uFrame.ECS.Components;
    using uFrame.Json;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(2)]
    [uFrame.Attributes.uFrameIdentifier("14d8a89d-b9e1-47a5-8b63-62289c9c4389")]
    public partial class HealthComp : uFrame.ECS.Components.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Int32 _leben;
        
        private Subject<PropertyChangedEvent<Int32>> _lebenObservable;
        
        private PropertyChangedEvent<Int32> _lebenEvent;
        
        public override int ComponentId {
            get {
                return 2;
            }
        }
        
        public IObservable<PropertyChangedEvent<Int32>> lebenObservable {
            get {
                return _lebenObservable ?? (_lebenObservable = new Subject<PropertyChangedEvent<Int32>>());
            }
        }
        
        public Int32 leben {
            get {
                return _leben;
            }
            set {
                Setleben(value);
            }
        }
        
        public virtual void Setleben(Int32 value) {
            SetProperty(ref _leben, value, ref _lebenEvent, _lebenObservable);
        }
    }
}
