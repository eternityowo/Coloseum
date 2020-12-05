using Leopotam.Ecs;
using UnityEngine;

namespace Client 
{
    public struct EcsC1
    {
        public float Speed;
        public Vector3 Direction;
        public Transform transform;
        // add your data here.
    }

    public struct IsDaniil : IEcsIgnoreInFilter
    {
        
    }

    public struct EcsC2
    {
        public float Hp;
    }
}