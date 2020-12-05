using Leopotam.Ecs;
using UnityEngine;

namespace Client 
{
    sealed class EcsRunSystem1 : IEcsRunSystem, IEcsInitSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly EcsFilter<EcsC1, EcsC2> _filter = null;
        
        void IEcsRunSystem.Run () 
        {
            foreach (var id in _filter)
            {
                var en = _filter.GetEntity(id);
                ref var moveC = ref en.Get<EcsC1>();
                //var ecs2 = en.Get<EcsC2>();

                moveC.transform.position += moveC.Direction * moveC.Speed * Time.deltaTime;
            }
        }

        public void Init()
        {
            foreach (var gameObject in GameObject.FindGameObjectsWithTag("Player"))
            {
                var en = _world.NewEntity();
                en.Get<EcsC1>().Speed = 10;
                en.Get<EcsC1>().transform = gameObject.transform;
                en.Get<EcsC1>().Direction = gameObject.transform.up;
            }
        }
    }
}