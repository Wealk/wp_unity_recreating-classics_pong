//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Inputs/PongActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PongActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PongActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PongActions"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""f6a5e61d-81de-4c57-8776-95ea050c5e36"",
            ""actions"": [
                {
                    ""name"": ""OptionMovement"",
                    ""type"": ""Button"",
                    ""id"": ""f5f71194-151a-4bb4-95ea-39b30f7945dc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OptionSelection"",
                    ""type"": ""Button"",
                    ""id"": ""0534b401-7fff-4a95-aff4-d20ff8fb11d4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WS"",
                    ""id"": ""f725e06b-7a79-4c30-a661-ef3688fc3c79"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OptionMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""57f4e898-b788-4e96-9ab4-77b61ed70255"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OptionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6100b0a0-8fca-4636-adcb-dfe4eeec5d32"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OptionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""4e7c2de0-b61d-4a46-92b3-ce9d8d435589"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OptionMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fcca8286-84ce-420b-bd29-d12f97893c78"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OptionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""439cf23a-859a-4a9f-b07b-3bfaf615b5f1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OptionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""087f6378-82c6-4eac-b2c3-5f7619d3d3fe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OptionSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""335fdce0-7a76-4a58-8511-cdf74826975c"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OptionSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game"",
            ""id"": ""a1b25275-d267-42fe-9249-9cf596506012"",
            ""actions"": [
                {
                    ""name"": ""PaddleLeft"",
                    ""type"": ""Button"",
                    ""id"": ""1e380279-7042-4fb8-b67a-9409f93fc251"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PaddleRight"",
                    ""type"": ""Button"",
                    ""id"": ""8b328b49-c0f0-4aab-bec1-fdc738c92e0f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""5fe86ca2-53eb-4340-a164-946ff05483ab"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WS"",
                    ""id"": ""29508a2e-39cd-45ca-b4de-d8b744a59358"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PaddleLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2136d99d-1eaa-49b9-aad7-5eef15bf309b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PaddleLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e8307499-aa56-4eed-b714-f0237df9d2c4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PaddleLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""12aefe8d-0a3f-4334-8d49-c15e6a7e74b6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PaddleRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""78a196cb-06a3-4579-9f74-e5cee028ceb9"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PaddleRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b804cc32-195f-49f6-8f2e-09a7e8574808"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PaddleRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a148a182-6fba-4294-bfbd-0c11510a68d4"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""EndMenu"",
            ""id"": ""4bc68aa0-ca69-4604-bcd7-515bdeae260c"",
            ""actions"": [
                {
                    ""name"": ""Continue"",
                    ""type"": ""Button"",
                    ""id"": ""1c756f63-e8cb-42a7-9219-db02d6a4a0f0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f14a59cf-ac61-471a-93db-ba3f679e20c2"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_OptionMovement = m_Menu.FindAction("OptionMovement", throwIfNotFound: true);
        m_Menu_OptionSelection = m_Menu.FindAction("OptionSelection", throwIfNotFound: true);
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_PaddleLeft = m_Game.FindAction("PaddleLeft", throwIfNotFound: true);
        m_Game_PaddleRight = m_Game.FindAction("PaddleRight", throwIfNotFound: true);
        m_Game_Reset = m_Game.FindAction("Reset", throwIfNotFound: true);
        // EndMenu
        m_EndMenu = asset.FindActionMap("EndMenu", throwIfNotFound: true);
        m_EndMenu_Continue = m_EndMenu.FindAction("Continue", throwIfNotFound: true);
    }

    ~@PongActions()
    {
        UnityEngine.Debug.Assert(!m_Menu.enabled, "This will cause a leak and performance issues, PongActions.Menu.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_Game.enabled, "This will cause a leak and performance issues, PongActions.Game.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_EndMenu.enabled, "This will cause a leak and performance issues, PongActions.EndMenu.Disable() has not been called.");
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Menu
    private readonly InputActionMap m_Menu;
    private List<IMenuActions> m_MenuActionsCallbackInterfaces = new List<IMenuActions>();
    private readonly InputAction m_Menu_OptionMovement;
    private readonly InputAction m_Menu_OptionSelection;
    public struct MenuActions
    {
        private @PongActions m_Wrapper;
        public MenuActions(@PongActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @OptionMovement => m_Wrapper.m_Menu_OptionMovement;
        public InputAction @OptionSelection => m_Wrapper.m_Menu_OptionSelection;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void AddCallbacks(IMenuActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuActionsCallbackInterfaces.Add(instance);
            @OptionMovement.started += instance.OnOptionMovement;
            @OptionMovement.performed += instance.OnOptionMovement;
            @OptionMovement.canceled += instance.OnOptionMovement;
            @OptionSelection.started += instance.OnOptionSelection;
            @OptionSelection.performed += instance.OnOptionSelection;
            @OptionSelection.canceled += instance.OnOptionSelection;
        }

        private void UnregisterCallbacks(IMenuActions instance)
        {
            @OptionMovement.started -= instance.OnOptionMovement;
            @OptionMovement.performed -= instance.OnOptionMovement;
            @OptionMovement.canceled -= instance.OnOptionMovement;
            @OptionSelection.started -= instance.OnOptionSelection;
            @OptionSelection.performed -= instance.OnOptionSelection;
            @OptionSelection.canceled -= instance.OnOptionSelection;
        }

        public void RemoveCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Game
    private readonly InputActionMap m_Game;
    private List<IGameActions> m_GameActionsCallbackInterfaces = new List<IGameActions>();
    private readonly InputAction m_Game_PaddleLeft;
    private readonly InputAction m_Game_PaddleRight;
    private readonly InputAction m_Game_Reset;
    public struct GameActions
    {
        private @PongActions m_Wrapper;
        public GameActions(@PongActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PaddleLeft => m_Wrapper.m_Game_PaddleLeft;
        public InputAction @PaddleRight => m_Wrapper.m_Game_PaddleRight;
        public InputAction @Reset => m_Wrapper.m_Game_Reset;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void AddCallbacks(IGameActions instance)
        {
            if (instance == null || m_Wrapper.m_GameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameActionsCallbackInterfaces.Add(instance);
            @PaddleLeft.started += instance.OnPaddleLeft;
            @PaddleLeft.performed += instance.OnPaddleLeft;
            @PaddleLeft.canceled += instance.OnPaddleLeft;
            @PaddleRight.started += instance.OnPaddleRight;
            @PaddleRight.performed += instance.OnPaddleRight;
            @PaddleRight.canceled += instance.OnPaddleRight;
            @Reset.started += instance.OnReset;
            @Reset.performed += instance.OnReset;
            @Reset.canceled += instance.OnReset;
        }

        private void UnregisterCallbacks(IGameActions instance)
        {
            @PaddleLeft.started -= instance.OnPaddleLeft;
            @PaddleLeft.performed -= instance.OnPaddleLeft;
            @PaddleLeft.canceled -= instance.OnPaddleLeft;
            @PaddleRight.started -= instance.OnPaddleRight;
            @PaddleRight.performed -= instance.OnPaddleRight;
            @PaddleRight.canceled -= instance.OnPaddleRight;
            @Reset.started -= instance.OnReset;
            @Reset.performed -= instance.OnReset;
            @Reset.canceled -= instance.OnReset;
        }

        public void RemoveCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameActions instance)
        {
            foreach (var item in m_Wrapper.m_GameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameActions @Game => new GameActions(this);

    // EndMenu
    private readonly InputActionMap m_EndMenu;
    private List<IEndMenuActions> m_EndMenuActionsCallbackInterfaces = new List<IEndMenuActions>();
    private readonly InputAction m_EndMenu_Continue;
    public struct EndMenuActions
    {
        private @PongActions m_Wrapper;
        public EndMenuActions(@PongActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Continue => m_Wrapper.m_EndMenu_Continue;
        public InputActionMap Get() { return m_Wrapper.m_EndMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EndMenuActions set) { return set.Get(); }
        public void AddCallbacks(IEndMenuActions instance)
        {
            if (instance == null || m_Wrapper.m_EndMenuActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_EndMenuActionsCallbackInterfaces.Add(instance);
            @Continue.started += instance.OnContinue;
            @Continue.performed += instance.OnContinue;
            @Continue.canceled += instance.OnContinue;
        }

        private void UnregisterCallbacks(IEndMenuActions instance)
        {
            @Continue.started -= instance.OnContinue;
            @Continue.performed -= instance.OnContinue;
            @Continue.canceled -= instance.OnContinue;
        }

        public void RemoveCallbacks(IEndMenuActions instance)
        {
            if (m_Wrapper.m_EndMenuActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IEndMenuActions instance)
        {
            foreach (var item in m_Wrapper.m_EndMenuActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_EndMenuActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public EndMenuActions @EndMenu => new EndMenuActions(this);
    public interface IMenuActions
    {
        void OnOptionMovement(InputAction.CallbackContext context);
        void OnOptionSelection(InputAction.CallbackContext context);
    }
    public interface IGameActions
    {
        void OnPaddleLeft(InputAction.CallbackContext context);
        void OnPaddleRight(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
    }
    public interface IEndMenuActions
    {
        void OnContinue(InputAction.CallbackContext context);
    }
}
