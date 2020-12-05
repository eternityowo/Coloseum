using AppData;
using Client;
using Coloseum.Components.Events.InputEvents;
using Coloseum.Systems;
using Coloseum.Systems.Controller;
using Coloseum.Systems.Controller.Init;
using Leopotam.Ecs;
using SpaceInvadersLeoEcs.Services;
using UnityEngine;

namespace Coloseum 
{
    sealed class EcsStartup : MonoBehaviour 
    {
        public GameConfiguration gameConfiguration = null;
        
        EcsWorld _world;
        EcsSystems _systems;

        void Start () 
        {
            var gameContext = new GameContext();
            // void can be switched to IEnumerator for support coroutines.
            
            _world = new EcsWorld ();
            _systems = new EcsSystems (_world);
#if UNITY_EDITOR
            Leopotam.Ecs.UnityIntegration.EcsWorldObserver.Create (_world);
            Leopotam.Ecs.UnityIntegration.EcsSystemsObserver.Create (_systems);
#endif
            _systems
                .Add(new EcsRunSystem1())
                .Add(new InputInitSystem())
                .Add(new PlayerInitSystem())
                
                .Add(new MoveInputSystem())
                .Add(new MoveExecuteSystem())
                // register your systems here, for example:
                // .Add (new TestSystem1 ())
                // .Add (new TestSystem2 ())
                
                // register one-frame components (order is important), for example:
                // .OneFrame<TestComponent1> ()
                // .OneFrame<TestComponent2> ()
                
                // inject service instances here (order doesn't important), for example:
                // .Inject (new CameraService ())
                // .Inject (new NavMeshSupport ())
                .OneFrame<InputMoveEvent>()
                
                .Inject(gameConfiguration)
                .Inject(GetComponent<SceneData>())
                .Inject(gameContext)
                .Inject(new PoolsObject())
                .Init ();
        }

        void Update () 
        {
            _systems?.Run ();
        }

        void OnDestroy () 
        {
            if (_systems != null) 
            {
                _systems.Destroy ();
                _systems = null;
                _world.Destroy ();
                _world = null;
            }
        }
    }
}