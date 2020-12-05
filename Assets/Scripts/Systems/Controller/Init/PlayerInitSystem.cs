using System.Collections;
using System.Collections.Generic;
using AppData;
using Coloseum.Components.WrappersMonoBehaviour;
using Coloseum.Systems.ViewModel;
using Common.Extensions.Components;
using Common.Extensions.UnityComponent;
using Leopotam.Ecs;
using UnityEngine;

namespace Coloseum.Systems.Controller.Init
{
    internal sealed class PlayerInitSystem : IEcsInitSystem
    {
        // auto-injected fields.
        private readonly EcsWorld _world = null;
        private readonly SceneData _sceneData = null;
        private readonly GameConfiguration _gameConfiguration = null;

        void IEcsInitSystem.Init()
        {
            if (_sceneData.Player1 != null) InitPlayer(_sceneData.Player1, 1);
            if (_sceneData.Player2 != null) InitPlayer(_sceneData.Player2, 2);
        }

        private void InitPlayer(Transform playerTransform, in int numberPlayer)
        {
            var player = CreatePlayer(playerTransform, numberPlayer);
            SetStartGun(player, playerTransform);
        }

        private EcsEntity CreatePlayer(Transform playerTransform, in int numberPlayer)
        {
            if (playerTransform == null) return default;
            var rigidBody2D = playerTransform.GetComponent<Rigidbody2D>();
            
            var entity = _world.NewEntity();
            entity.Get<ViewObjectComponent>().ViewObject = new ViewObjectUnity(playerTransform, rigidBody2D);
            entity.Get<WrapperUnityObjectComponent<LineRenderer>>().Value = playerTransform.GetComponent<LineRenderer>();
            entity.Get<PlayerComponent>().Number = numberPlayer;
            entity.Get<MoveComponent>();
            entity.Get<HealthBaseComponent>().Value = 1;
            entity.Get<HealthCurrentComponent>().Value = 1;
            
            playerTransform.GetProvider().SetEntity(entity);
            
            return entity;
        }

        private void SetStartGun(in EcsEntity player, Transform playerTransform)
        {

        }
    }
}