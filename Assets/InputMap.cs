// GENERATED AUTOMATICALLY FROM 'Assets/InputMap.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMap : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""06bac1a4-f84c-4891-833d-178515a797ad"",
            ""actions"": [
                {
                    ""name"": ""MoveV"",
                    ""type"": ""Button"",
                    ""id"": ""c0e9cb3f-581b-424f-a87e-ea11cc193290"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveH"",
                    ""type"": ""Button"",
                    ""id"": ""ca473af9-97b4-4557-8805-5864eccbe654"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""fbf4b74b-3aa8-4977-8bb9-5848e8d5f055"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defence"",
                    ""type"": ""Button"",
                    ""id"": ""0415c1b4-9182-45db-bc21-fa548d3177b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2e01036f-caae-4027-9a0a-76bb64d9472c"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f94097b-8aef-4f19-8b91-62f5a8e6a134"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""56dcaf3b-efb9-48dd-9527-74e562d583d7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""69fc0a09-d638-40db-9f88-81ac18e9fcd3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fe230a12-a488-46b0-820d-8a81545e570c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7d5d69af-f9b3-4ac5-a94e-5fc5bf72b96b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""42c3dfb6-ac0f-4eb0-ae9b-3cfa9200738f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""53f34b11-1776-48d6-98f0-e6f51a7b16ef"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""75eb3465-eec0-468b-8c6c-cfde78bfc7c5"",
            ""actions"": [
                {
                    ""name"": ""MoveV"",
                    ""type"": ""Button"",
                    ""id"": ""eaa14035-17d0-4a5b-b1be-c72584b36924"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveH"",
                    ""type"": ""Button"",
                    ""id"": ""9019f95c-10b3-4e82-85b7-778864fab44e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""4f517b0f-6f09-4b7b-9533-b5262a820bf5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defence"",
                    ""type"": ""Button"",
                    ""id"": ""c31d4cac-30d9-42ec-9859-0e59615f18c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""42a83dc0-dfaf-41bc-bd0c-9ab8179340c1"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2c46055-66f2-4c90-9e36-1b53df57bad1"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""479c417c-af6f-4790-b198-4f9104491661"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""370eeeba-7799-44fe-98ad-b4c6678de90f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d756fdff-9487-4b6b-84c4-78853fae73f6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""612d8499-5b28-47f2-a261-8162d091e06d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0465dfc9-1642-4fad-b438-9d59d6b73331"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""80c3d295-2e15-44c5-b207-ea16e809ab8b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_MoveV = m_Player1.FindAction("MoveV", throwIfNotFound: true);
        m_Player1_MoveH = m_Player1.FindAction("MoveH", throwIfNotFound: true);
        m_Player1_Attack = m_Player1.FindAction("Attack", throwIfNotFound: true);
        m_Player1_Defence = m_Player1.FindAction("Defence", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_MoveV = m_Player2.FindAction("MoveV", throwIfNotFound: true);
        m_Player2_MoveH = m_Player2.FindAction("MoveH", throwIfNotFound: true);
        m_Player2_Attack = m_Player2.FindAction("Attack", throwIfNotFound: true);
        m_Player2_Defence = m_Player2.FindAction("Defence", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_MoveV;
    private readonly InputAction m_Player1_MoveH;
    private readonly InputAction m_Player1_Attack;
    private readonly InputAction m_Player1_Defence;
    public struct Player1Actions
    {
        private @InputMap m_Wrapper;
        public Player1Actions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveV => m_Wrapper.m_Player1_MoveV;
        public InputAction @MoveH => m_Wrapper.m_Player1_MoveH;
        public InputAction @Attack => m_Wrapper.m_Player1_Attack;
        public InputAction @Defence => m_Wrapper.m_Player1_Defence;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @MoveV.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveV;
                @MoveV.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveV;
                @MoveV.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveV;
                @MoveH.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveH;
                @MoveH.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveH;
                @MoveH.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveH;
                @Attack.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Defence.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDefence;
                @Defence.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDefence;
                @Defence.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDefence;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveV.started += instance.OnMoveV;
                @MoveV.performed += instance.OnMoveV;
                @MoveV.canceled += instance.OnMoveV;
                @MoveH.started += instance.OnMoveH;
                @MoveH.performed += instance.OnMoveH;
                @MoveH.canceled += instance.OnMoveH;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Defence.started += instance.OnDefence;
                @Defence.performed += instance.OnDefence;
                @Defence.canceled += instance.OnDefence;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_MoveV;
    private readonly InputAction m_Player2_MoveH;
    private readonly InputAction m_Player2_Attack;
    private readonly InputAction m_Player2_Defence;
    public struct Player2Actions
    {
        private @InputMap m_Wrapper;
        public Player2Actions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveV => m_Wrapper.m_Player2_MoveV;
        public InputAction @MoveH => m_Wrapper.m_Player2_MoveH;
        public InputAction @Attack => m_Wrapper.m_Player2_Attack;
        public InputAction @Defence => m_Wrapper.m_Player2_Defence;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @MoveV.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveV;
                @MoveV.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveV;
                @MoveV.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveV;
                @MoveH.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveH;
                @MoveH.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveH;
                @MoveH.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveH;
                @Attack.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Defence.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDefence;
                @Defence.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDefence;
                @Defence.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDefence;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveV.started += instance.OnMoveV;
                @MoveV.performed += instance.OnMoveV;
                @MoveV.canceled += instance.OnMoveV;
                @MoveH.started += instance.OnMoveH;
                @MoveH.performed += instance.OnMoveH;
                @MoveH.canceled += instance.OnMoveH;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Defence.started += instance.OnDefence;
                @Defence.performed += instance.OnDefence;
                @Defence.canceled += instance.OnDefence;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    public interface IPlayer1Actions
    {
        void OnMoveV(InputAction.CallbackContext context);
        void OnMoveH(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnDefence(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMoveV(InputAction.CallbackContext context);
        void OnMoveH(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnDefence(InputAction.CallbackContext context);
    }
}
