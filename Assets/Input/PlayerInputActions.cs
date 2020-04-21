// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""748fb3b1-b6b8-404b-89c6-23172100554d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""74077f38-effa-49f6-ab6b-484a95758612"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BattleStance"",
                    ""type"": ""Button"",
                    ""id"": ""fcdc4d1d-8894-47ae-956e-31af08e1500c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""StandardAttack"",
                    ""type"": ""Button"",
                    ""id"": ""e56f7370-bf07-4d5f-81ab-04a8463e5144"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LightAttack"",
                    ""type"": ""Button"",
                    ""id"": ""21bc16a6-62c3-4741-9976-289e71310d19"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""HardAttack"",
                    ""type"": ""Button"",
                    ""id"": ""38e34e55-d554-48f4-bb7f-e98d34a5a858"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fe63e329-9a7a-4a09-8393-4476ab17a79b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""50bb8282-981e-47fe-85ce-030591dfcd71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""8331c556-3677-461f-ba34-4db3b0035fc5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""d29f1852-5cfb-49f5-a14d-7bdd12e51ced"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""32f0c989-b3aa-489b-ac11-d66b82bf59f5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c3cedfef-b799-4aaf-bff3-2c6349b6e123"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4854b938-bd01-4f2c-b82a-9d73ea80c020"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""eca94231-8cb8-44fa-9ba6-990bc23e0af5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c0947900-67d0-4cfd-aede-16e91668f2db"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""BattleStance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1547a47f-d8f2-4285-9f85-e0f9e6023b38"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""BattleStance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c86cd28e-5d44-4a49-b6da-7852d29f322e"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""StandardAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db92976f-9ad4-4484-b63c-19e445c675a7"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LightAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e6d307a-0318-4af3-857e-b74993921132"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""HardAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa33d139-c125-465c-90b1-c66e923e4c10"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c738f8e7-29f8-4a81-a7c9-02f67975dbb5"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45a7f201-329f-45e5-9a9b-22a40b8ab66a"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Move = m_PlayerControls.FindAction("Move", throwIfNotFound: true);
        m_PlayerControls_BattleStance = m_PlayerControls.FindAction("BattleStance", throwIfNotFound: true);
        m_PlayerControls_StandardAttack = m_PlayerControls.FindAction("StandardAttack", throwIfNotFound: true);
        m_PlayerControls_LightAttack = m_PlayerControls.FindAction("LightAttack", throwIfNotFound: true);
        m_PlayerControls_HardAttack = m_PlayerControls.FindAction("HardAttack", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_Run = m_PlayerControls.FindAction("Run", throwIfNotFound: true);
        m_PlayerControls_Roll = m_PlayerControls.FindAction("Roll", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Move;
    private readonly InputAction m_PlayerControls_BattleStance;
    private readonly InputAction m_PlayerControls_StandardAttack;
    private readonly InputAction m_PlayerControls_LightAttack;
    private readonly InputAction m_PlayerControls_HardAttack;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_Run;
    private readonly InputAction m_PlayerControls_Roll;
    public struct PlayerControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
        public InputAction @BattleStance => m_Wrapper.m_PlayerControls_BattleStance;
        public InputAction @StandardAttack => m_Wrapper.m_PlayerControls_StandardAttack;
        public InputAction @LightAttack => m_Wrapper.m_PlayerControls_LightAttack;
        public InputAction @HardAttack => m_Wrapper.m_PlayerControls_HardAttack;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @Run => m_Wrapper.m_PlayerControls_Run;
        public InputAction @Roll => m_Wrapper.m_PlayerControls_Roll;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @BattleStance.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBattleStance;
                @BattleStance.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBattleStance;
                @BattleStance.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBattleStance;
                @StandardAttack.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnStandardAttack;
                @StandardAttack.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnStandardAttack;
                @StandardAttack.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnStandardAttack;
                @LightAttack.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLightAttack;
                @LightAttack.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLightAttack;
                @LightAttack.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLightAttack;
                @HardAttack.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHardAttack;
                @HardAttack.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHardAttack;
                @HardAttack.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHardAttack;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Run.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Roll.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRoll;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @BattleStance.started += instance.OnBattleStance;
                @BattleStance.performed += instance.OnBattleStance;
                @BattleStance.canceled += instance.OnBattleStance;
                @StandardAttack.started += instance.OnStandardAttack;
                @StandardAttack.performed += instance.OnStandardAttack;
                @StandardAttack.canceled += instance.OnStandardAttack;
                @LightAttack.started += instance.OnLightAttack;
                @LightAttack.performed += instance.OnLightAttack;
                @LightAttack.canceled += instance.OnLightAttack;
                @HardAttack.started += instance.OnHardAttack;
                @HardAttack.performed += instance.OnHardAttack;
                @HardAttack.canceled += instance.OnHardAttack;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnBattleStance(InputAction.CallbackContext context);
        void OnStandardAttack(InputAction.CallbackContext context);
        void OnLightAttack(InputAction.CallbackContext context);
        void OnHardAttack(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
    }
}
