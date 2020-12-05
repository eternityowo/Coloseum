using System;
using AppData;
using Coloseum.Components.Events.InputEvents;
using Coloseum.Components.WrappersMonoBehaviour;
using Leopotam.Ecs;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Coloseum.Systems
{
    internal sealed class MoveInputSystem : IEcsRunSystem
    {
        // auto-injected fields.
        private readonly GameConfiguration _gameConfiguration = null;

        private readonly EcsFilter<InputMoveEvent> _filterMoveStart = null;
        private readonly EcsFilter<PlayerComponent, MoveComponent> _filterMove = null;

        void IEcsRunSystem.Run()
        {
            foreach (var i in _filterMoveStart)
            {
                ref var moveEvent = ref _filterMoveStart.Get1(i);
                if (moveEvent.Axis == 0)
                {
                    var direction = Vector2.zero;
                    ProcessMove(moveEvent.PlayerNumber, moveEvent.State, direction);
                }
                else
                {
                    var direction = moveEvent.State == MoveState.Horizontal ? GetDirection(moveEvent.Axis) : GetDirectionSecond(moveEvent.Axis);
                    ProcessMove(moveEvent.PlayerNumber, moveEvent.State, direction);
                }
            }
        }

        private void ProcessMove(in int numberPlayer, in MoveState state, in Vector2 direction = new Vector2())
        {
            foreach (var i in _filterMove)
            {
                if (!IsPlayerWithNumber(numberPlayer, i)) continue;

                var speedPlayer = GetSpeedPlayer(numberPlayer);

                ref var move = ref _filterMove.Get2(i);
                move.Speed = speedPlayer;
                move.Direct = new Vector2(state == MoveState.Horizontal ? direction.x : move.Direct.x, state == MoveState.Vertical ? direction.y : move.Direct.y);
                
                // if (doMove)
                // {
                //     MovePlayer(ref move, direction, speedPlayer);
                // }
                // else
                // {
                //     StopPlayer(ref move);
                // }
            }
        }

        private bool IsPlayerWithNumber(in int numberPlayer, in int indexFilter)
        {
            var playerComponent = _filterMove.Get1(indexFilter);
            return playerComponent.Number == numberPlayer;
        }

        private float GetSpeedPlayer(in int numberPlayer)
        {
            if (numberPlayer == 1) return _gameConfiguration.Player1Speed;
            if (numberPlayer == 2) return _gameConfiguration.Player2Speed;
            throw new Exception();
        }

        private void MovePlayer(ref MoveComponent component, in Vector2 direction, in float speed)
        {
            component.Speed = speed;
            component.Direct = (component.Direct + direction).normalized;
        }

        private void StopPlayer(ref MoveComponent component)
        {
            component.Speed = 0;
        }

        private Vector2 GetDirection(in float axis) => axis >= 0 ? Vector2.right : Vector2.left;
        private Vector2 GetDirectionSecond(in float axis) => axis >= 0 ? Vector2.up : Vector2.down;
    }
}