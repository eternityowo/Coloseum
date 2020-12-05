using Leopotam.Ecs;

namespace Common.Extensions.UnityComponents
{
    public interface IEcsUnityProvider
    {
        ref EcsEntity Entity { get; }

        void SetEntity(in EcsEntity entity);
    }
}