// GENERATED AUTOMATICALLY FROM 'Assets/Input/MasterInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MasterInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MasterInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MasterInput"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""02f34e63-f798-4efc-b3cf-78a5742e891a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6daa9173-efab-42c4-8f5d-4155a3360b50"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sonar"",
                    ""type"": ""Button"",
                    ""id"": ""d2e9487d-70c8-48ff-9cd4-548fad56fcc0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Light"",
                    ""type"": ""Button"",
                    ""id"": ""f9bafde6-6f91-455d-8c2a-f675b034f5d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePos"",
                    ""type"": ""Value"",
                    ""id"": ""2fb8e44f-b507-4451-b859-2a1e55e4cae8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""50b9de63-2888-40da-a119-9ebfa2d20473"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dialogue"",
                    ""type"": ""Button"",
                    ""id"": ""2b0c4088-edc2-4f07-a389-eebbd3a40395"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CursorMove"",
                    ""type"": ""Value"",
                    ""id"": ""097a4402-1d71-4880-a93e-e87a760f88e9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Repair"",
                    ""type"": ""Value"",
                    ""id"": ""9c073645-8fa5-44cf-a72c-f3c1b7fd7b82"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Claw"",
                    ""type"": ""Button"",
                    ""id"": ""821394fb-daf9-4287-b4c8-92c40eeb414c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""6a2780f3-bae3-4d74-9122-d989d48951a0"",
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
                    ""id"": ""738ce381-8f87-4c13-8411-6af59b7474f3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""07cfc1b9-2b12-4114-9740-848e41e1db6a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c482124a-e419-4f16-bc2a-022214897d94"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6072b4d0-c04a-4c23-9b51-f0d18cad7ba7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""39e4dedb-5d50-4f1d-943e-541b82557c0c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bb835ac-ee07-499d-af0e-514181ed97d4"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd179fe3-9128-4c66-ae35-0c7d7770080a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Sonar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32f5fbb7-98c2-4b5a-921c-48fd83d37c33"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Sonar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59f1e95a-7989-41e6-b873-d254f579606d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Light"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00718c55-990f-497b-9e1e-2e911854dc9b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Light"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fd79ea1-474f-4471-8425-baec95d891e2"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65a54c42-7475-474c-a620-4f61001e3817"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eaeea845-8d01-4330-b735-776208182dcb"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a2fb96e-5746-4a1f-8ee2-b5c02451db36"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Dialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6870d37-617f-4579-80f7-16676d55b2a7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Dialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b10cd39-7e7c-45b9-bba3-51bdf645d9ea"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Dialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d66f1f0-0d4c-4568-935c-d2926b748b94"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d60aa37-c4d3-495f-a631-2ac092197ef3"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CursorMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9e2c45d-cf77-4b38-a0a5-8fe9af21acab"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Repair"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b256d853-4e32-4f2f-8cb3-e50367da542e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Repair"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2168560-e4f9-46ec-b9ef-9b9014992bc6"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Claw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuNavigation"",
            ""id"": ""8517bc0a-39c2-4156-b086-0f3952912533"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""07bfc929-3d74-4a67-9387-efe7803296c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NavigateMenu"",
                    ""type"": ""PassThrough"",
                    ""id"": ""12657f6f-a567-490c-a1cb-007711cfaa24"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""3180a6a4-6489-4fdb-90bd-2176ff8750e7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""68a84fbd-7dd7-4e3b-9312-b4c2882101c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""8d9de841-157a-49f7-bc10-9127a4c695cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0859aa76-a08d-4cca-bc58-10b02e1c8d66"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dddfebb8-0268-41db-837a-f885bec83b50"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56cbc744-f523-4465-b0e3-9bb4fdb176b7"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c36a398e-e3b0-4a9a-b673-33416abe7066"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""02f4447b-37af-4b10-bccc-59edc9f02f0e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""NavigateMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""69233ac6-2df0-4843-a81d-f758876d0438"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""NavigateMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ed062ab6-65c2-4f02-abd5-f6d65743a745"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""NavigateMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cd836fea-d984-4012-a677-33f84999d142"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""NavigateMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e3494b38-669e-4314-9f44-cd34841ced3a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af59f7f0-d9a9-4b4f-a6f5-d90288c615f7"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5210fbf6-d92d-472f-ab43-00b111cb2ede"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bd2258e-32db-419e-afb2-7c2701e736f9"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b86497b2-09e9-4579-ab98-19fc27e53258"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard+Mouse"",
            ""bindingGroup"": ""Keyboard+Mouse"",
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
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
        m_PlayerControls_Sonar = m_PlayerControls.FindAction("Sonar", throwIfNotFound: true);
        m_PlayerControls_Light = m_PlayerControls.FindAction("Light", throwIfNotFound: true);
        m_PlayerControls_MousePos = m_PlayerControls.FindAction("MousePos", throwIfNotFound: true);
        m_PlayerControls_Pause = m_PlayerControls.FindAction("Pause", throwIfNotFound: true);
        m_PlayerControls_Dialogue = m_PlayerControls.FindAction("Dialogue", throwIfNotFound: true);
        m_PlayerControls_CursorMove = m_PlayerControls.FindAction("CursorMove", throwIfNotFound: true);
        m_PlayerControls_Repair = m_PlayerControls.FindAction("Repair", throwIfNotFound: true);
        m_PlayerControls_Claw = m_PlayerControls.FindAction("Claw", throwIfNotFound: true);
        // MenuNavigation
        m_MenuNavigation = asset.FindActionMap("MenuNavigation", throwIfNotFound: true);
        m_MenuNavigation_Select = m_MenuNavigation.FindAction("Select", throwIfNotFound: true);
        m_MenuNavigation_NavigateMenu = m_MenuNavigation.FindAction("NavigateMenu", throwIfNotFound: true);
        m_MenuNavigation_Point = m_MenuNavigation.FindAction("Point", throwIfNotFound: true);
        m_MenuNavigation_Submit = m_MenuNavigation.FindAction("Submit", throwIfNotFound: true);
        m_MenuNavigation_Cancel = m_MenuNavigation.FindAction("Cancel", throwIfNotFound: true);
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
    private readonly InputAction m_PlayerControls_Sonar;
    private readonly InputAction m_PlayerControls_Light;
    private readonly InputAction m_PlayerControls_MousePos;
    private readonly InputAction m_PlayerControls_Pause;
    private readonly InputAction m_PlayerControls_Dialogue;
    private readonly InputAction m_PlayerControls_CursorMove;
    private readonly InputAction m_PlayerControls_Repair;
    private readonly InputAction m_PlayerControls_Claw;
    public struct PlayerControlsActions
    {
        private @MasterInput m_Wrapper;
        public PlayerControlsActions(@MasterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
        public InputAction @Sonar => m_Wrapper.m_PlayerControls_Sonar;
        public InputAction @Light => m_Wrapper.m_PlayerControls_Light;
        public InputAction @MousePos => m_Wrapper.m_PlayerControls_MousePos;
        public InputAction @Pause => m_Wrapper.m_PlayerControls_Pause;
        public InputAction @Dialogue => m_Wrapper.m_PlayerControls_Dialogue;
        public InputAction @CursorMove => m_Wrapper.m_PlayerControls_CursorMove;
        public InputAction @Repair => m_Wrapper.m_PlayerControls_Repair;
        public InputAction @Claw => m_Wrapper.m_PlayerControls_Claw;
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
                @Sonar.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSonar;
                @Sonar.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSonar;
                @Sonar.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSonar;
                @Light.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLight;
                @Light.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLight;
                @Light.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLight;
                @MousePos.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMousePos;
                @MousePos.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMousePos;
                @MousePos.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMousePos;
                @Pause.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Dialogue.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDialogue;
                @Dialogue.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDialogue;
                @Dialogue.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDialogue;
                @CursorMove.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCursorMove;
                @CursorMove.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCursorMove;
                @CursorMove.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCursorMove;
                @Repair.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRepair;
                @Repair.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRepair;
                @Repair.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRepair;
                @Claw.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnClaw;
                @Claw.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnClaw;
                @Claw.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnClaw;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Sonar.started += instance.OnSonar;
                @Sonar.performed += instance.OnSonar;
                @Sonar.canceled += instance.OnSonar;
                @Light.started += instance.OnLight;
                @Light.performed += instance.OnLight;
                @Light.canceled += instance.OnLight;
                @MousePos.started += instance.OnMousePos;
                @MousePos.performed += instance.OnMousePos;
                @MousePos.canceled += instance.OnMousePos;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Dialogue.started += instance.OnDialogue;
                @Dialogue.performed += instance.OnDialogue;
                @Dialogue.canceled += instance.OnDialogue;
                @CursorMove.started += instance.OnCursorMove;
                @CursorMove.performed += instance.OnCursorMove;
                @CursorMove.canceled += instance.OnCursorMove;
                @Repair.started += instance.OnRepair;
                @Repair.performed += instance.OnRepair;
                @Repair.canceled += instance.OnRepair;
                @Claw.started += instance.OnClaw;
                @Claw.performed += instance.OnClaw;
                @Claw.canceled += instance.OnClaw;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // MenuNavigation
    private readonly InputActionMap m_MenuNavigation;
    private IMenuNavigationActions m_MenuNavigationActionsCallbackInterface;
    private readonly InputAction m_MenuNavigation_Select;
    private readonly InputAction m_MenuNavigation_NavigateMenu;
    private readonly InputAction m_MenuNavigation_Point;
    private readonly InputAction m_MenuNavigation_Submit;
    private readonly InputAction m_MenuNavigation_Cancel;
    public struct MenuNavigationActions
    {
        private @MasterInput m_Wrapper;
        public MenuNavigationActions(@MasterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_MenuNavigation_Select;
        public InputAction @NavigateMenu => m_Wrapper.m_MenuNavigation_NavigateMenu;
        public InputAction @Point => m_Wrapper.m_MenuNavigation_Point;
        public InputAction @Submit => m_Wrapper.m_MenuNavigation_Submit;
        public InputAction @Cancel => m_Wrapper.m_MenuNavigation_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_MenuNavigation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuNavigationActions set) { return set.Get(); }
        public void SetCallbacks(IMenuNavigationActions instance)
        {
            if (m_Wrapper.m_MenuNavigationActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSelect;
                @NavigateMenu.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnNavigateMenu;
                @NavigateMenu.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnNavigateMenu;
                @NavigateMenu.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnNavigateMenu;
                @Point.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnPoint;
                @Submit.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_MenuNavigationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @NavigateMenu.started += instance.OnNavigateMenu;
                @NavigateMenu.performed += instance.OnNavigateMenu;
                @NavigateMenu.canceled += instance.OnNavigateMenu;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public MenuNavigationActions @MenuNavigation => new MenuNavigationActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard+Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSonar(InputAction.CallbackContext context);
        void OnLight(InputAction.CallbackContext context);
        void OnMousePos(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnDialogue(InputAction.CallbackContext context);
        void OnCursorMove(InputAction.CallbackContext context);
        void OnRepair(InputAction.CallbackContext context);
        void OnClaw(InputAction.CallbackContext context);
    }
    public interface IMenuNavigationActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnNavigateMenu(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
