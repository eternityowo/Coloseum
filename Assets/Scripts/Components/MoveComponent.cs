using System;
using UnityEngine;

namespace Coloseum.Components.WrappersMonoBehaviour
{
    [Serializable]
    internal struct MoveComponent
    {
        public Vector2 Direct;
        public float Speed;
        public float RotationSpeed;
    }
    
    internal struct PlayerComponent
    {
        public int Number;
    }
    
    [Serializable]
    internal struct HealthBaseComponent
    {
        public int Value;
    }
    
    internal struct HealthCurrentComponent
    {
        public int Value;
    }
}