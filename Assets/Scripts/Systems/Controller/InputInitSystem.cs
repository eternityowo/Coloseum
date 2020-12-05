using System.Collections;
using System.Collections.Generic;
using AppData;
using Coloseum.Components.Events.InputEvents;
using Leopotam.Ecs;
using UnityEngine;
using Common.Extensions;

namespace Coloseum.Systems.Controller
{
     internal sealed class InputInitSystem : IEcsInitSystem, IEcsDestroySystem
    {
        // auto-injected fields.
        private readonly EcsWorld _world = null;
        private readonly GameContext _gameContext = null;
        
        private InputMap _inputControls;
        
        void IEcsInitSystem.Init()
        {
            _inputControls = new InputMap();
            _inputControls.Enable();

            // Common
            //_inputControls.Common.PauseQuit.performed += context => _world.SendMessage(new InputPauseQuitEvent());
            //_inputControls.Common.AnyKey.performed += context => _world.SendMessage(new InputAnyKeyEvent());
            
            // Move
            _inputControls.Player1.MoveH.started += context => 
                SendMessageInGame(new InputMoveEvent() {PlayerNumber = 1, Axis = context.ReadValue<float>(), State = MoveState.Horizontal});

            _inputControls.Player1.MoveH.canceled += context => 
                SendMessageInGame(new InputMoveEvent() {PlayerNumber = 1, Axis = 0, State = MoveState.Horizontal});
            
            _inputControls.Player1.MoveV.started += context => 
                SendMessageInGame(new InputMoveEvent() {PlayerNumber = 1, Axis = context.ReadValue<float>(), State = MoveState.Vertical});

            _inputControls.Player1.MoveV.canceled += context => 
                SendMessageInGame(new InputMoveEvent() {PlayerNumber = 1, Axis = 0, State = MoveState.Vertical});

            // Shoot
            // _inputControls.Player1.Shoot.started += context =>
            //     SendMessageInGame(new InputShootStartedEvent() {PlayerNumber = 1});
            //
            // _inputControls.Player2.Shoot.started += context => 
            //     SendMessageInGame(new InputShootStartedEvent() {PlayerNumber = 2});
        }

        private void SendMessageInGame<T>(in T messageEvent)
            where T : struct
        {
            //if(_gameContext.GameState != GameStates.Play) return;
            _world.SendMessage(messageEvent);
        }

        void IEcsDestroySystem.Destroy()
        {
            _inputControls.Disable();
        }
    }

}