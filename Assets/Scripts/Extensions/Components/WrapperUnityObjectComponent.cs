using UnityEngine;

namespace Common.Extensions.Components
{
    public struct WrapperUnityObjectComponent<T>
        where T : Object
    {
        public T Value;
    }
}