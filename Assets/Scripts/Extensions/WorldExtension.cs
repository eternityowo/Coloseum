using Leopotam.Ecs;

namespace Common.Extensions
{
    public static class WorldExtension
    {
        public static void SendMessage<T>(this EcsWorld world, in T messageEvent)
            where T : struct
        {
            ref var eventComponent = ref world.NewEntity().Get<T>();
            eventComponent = messageEvent;
        }
    }
}