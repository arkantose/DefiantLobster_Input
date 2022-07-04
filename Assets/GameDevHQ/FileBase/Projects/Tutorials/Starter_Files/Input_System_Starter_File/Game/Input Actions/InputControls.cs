//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/GameDevHQ/FileBase/Projects/Tutorials/Starter_Files/Input_System_Starter_File/Game/Input Actions/InputControls.inputactions
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

public partial class @InputControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""a2bacd4b-03b2-47b0-8ab9-f097a0d17cb0"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""b6910dfe-b7c1-44e8-9efe-126aa3b8eed3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""4c677cc6-5e5e-4c23-ba7e-11f32777dcbf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""8c4532e6-bf1b-435e-8e3d-0b1d23f7297b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HoldKey"",
                    ""type"": ""Button"",
                    ""id"": ""c7dd7187-8e85-4f76-86bd-be8d921995a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""8810c4ab-16a2-4321-bc63-25d6e41ddf6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""57c98d01-35e1-4d6c-86db-c5dd79de9c66"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ff331665-d928-449a-9e01-81bcb3403696"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e06ae4cc-fa46-4d37-89d4-1ae414f75fe0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8f7264e9-efe6-4741-8f4b-09e659ddca2e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""397f54e0-86b0-48f8-b4d7-4a43ebaa2db7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""753d8084-63a6-4759-90bf-802713e4b041"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51572235-8a79-4c01-ade8-d343ad6cbb4a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db371205-7131-4f71-80ec-0c994ac9160f"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoldKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4021e0f3-02ff-4ea9-bc86-a29a00ff822d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drone"",
            ""id"": ""a381f34a-1cfc-41e5-af81-69acaa475241"",
            ""actions"": [
                {
                    ""name"": ""FlyTilt"",
                    ""type"": ""Value"",
                    ""id"": ""193547f5-a7dd-4027-b986-064897ababf6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Ascend"",
                    ""type"": ""Button"",
                    ""id"": ""74701625-7078-457e-8149-de5b64b1ec26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Descend"",
                    ""type"": ""Button"",
                    ""id"": ""ca83a60f-5033-4fad-91ad-a98907c1a644"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlyRot"",
                    ""type"": ""Value"",
                    ""id"": ""9599e0c1-24d0-4398-b4f3-c9c13e3716d2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""22ffec1f-b586-4d18-9075-5a1f5c749267"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5efee572-07c3-4eca-a07f-5766953625f8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyTilt"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0cd06ebf-861c-4fd9-8415-fed4491101fc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""252bd4fc-7f1c-477f-a9e8-a0c2e0ea1208"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5d14af81-24f0-4d32-9238-f970987b6c9f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4e94fe13-8609-4d66-8d0e-ab75a707b834"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""168b3941-d964-4379-acd1-91a6f55214fe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ascend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ca8870a-f49b-48c2-92f1-d6ff99a43b1a"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Descend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9b0680c1-3e7f-4263-bb85-761cfca36cb4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyRot"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""46a3c2cb-6f73-44fc-bdea-8f0ebf205e2b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyRot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""03b1b2c7-0d6f-46d7-9aa1-370b8651144d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyRot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4898aeda-f3e6-4b6a-bab6-a1414c528c23"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyRot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""196b0585-6a98-4c0a-a14f-41f9ef0d32be"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyRot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cf16e4df-d9e4-4a6a-aeed-656de6c14edc"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ForkLift"",
            ""id"": ""3433fb67-f6b6-40d7-944a-858fc2d1b730"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c299671a-2a16-4cc9-ad4e-550670ad58b2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LiftUp"",
                    ""type"": ""Button"",
                    ""id"": ""f6fd10c3-9bda-4131-80cc-36bcde90a200"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LiftDown"",
                    ""type"": ""Button"",
                    ""id"": ""de6edcca-2513-4476-abcc-6bd31b4c47e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""0506bacc-ef5f-4806-abe8-7f7db22178fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""78fe1fc0-71d5-4489-8cc4-eb46d6e3a43b"",
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
                    ""id"": ""cb6961b0-2ac4-4768-b1de-51b0883738be"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c7e3eda9-fb31-40fc-b6a4-37f88165bde5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5a9a7759-a172-4f28-9b31-6fc38521ca9b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ef81fb2e-83af-40cc-bd04-66e94b626a53"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3eed8f46-5991-487c-958b-0b73b1a45c38"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b26766d4-4228-474b-9d09-3fd9d8c4c26a"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a11bf495-8266-45b8-a5da-1cddde3758ec"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Walk = m_Player.FindAction("Walk", throwIfNotFound: true);
        m_Player_Pickup = m_Player.FindAction("Pickup", throwIfNotFound: true);
        m_Player_Action = m_Player.FindAction("Action", throwIfNotFound: true);
        m_Player_HoldKey = m_Player.FindAction("HoldKey", throwIfNotFound: true);
        m_Player_Exit = m_Player.FindAction("Exit", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_FlyTilt = m_Drone.FindAction("FlyTilt", throwIfNotFound: true);
        m_Drone_Ascend = m_Drone.FindAction("Ascend", throwIfNotFound: true);
        m_Drone_Descend = m_Drone.FindAction("Descend", throwIfNotFound: true);
        m_Drone_FlyRot = m_Drone.FindAction("FlyRot", throwIfNotFound: true);
        m_Drone_Escape = m_Drone.FindAction("Escape", throwIfNotFound: true);
        // ForkLift
        m_ForkLift = asset.FindActionMap("ForkLift", throwIfNotFound: true);
        m_ForkLift_Move = m_ForkLift.FindAction("Move", throwIfNotFound: true);
        m_ForkLift_LiftUp = m_ForkLift.FindAction("LiftUp", throwIfNotFound: true);
        m_ForkLift_LiftDown = m_ForkLift.FindAction("LiftDown", throwIfNotFound: true);
        m_ForkLift_Exit = m_ForkLift.FindAction("Exit", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Walk;
    private readonly InputAction m_Player_Pickup;
    private readonly InputAction m_Player_Action;
    private readonly InputAction m_Player_HoldKey;
    private readonly InputAction m_Player_Exit;
    public struct PlayerActions
    {
        private @InputControls m_Wrapper;
        public PlayerActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Player_Walk;
        public InputAction @Pickup => m_Wrapper.m_Player_Pickup;
        public InputAction @Action => m_Wrapper.m_Player_Action;
        public InputAction @HoldKey => m_Wrapper.m_Player_HoldKey;
        public InputAction @Exit => m_Wrapper.m_Player_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Pickup.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @Action.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @HoldKey.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHoldKey;
                @HoldKey.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHoldKey;
                @HoldKey.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHoldKey;
                @Exit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @HoldKey.started += instance.OnHoldKey;
                @HoldKey.performed += instance.OnHoldKey;
                @HoldKey.canceled += instance.OnHoldKey;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private IDroneActions m_DroneActionsCallbackInterface;
    private readonly InputAction m_Drone_FlyTilt;
    private readonly InputAction m_Drone_Ascend;
    private readonly InputAction m_Drone_Descend;
    private readonly InputAction m_Drone_FlyRot;
    private readonly InputAction m_Drone_Escape;
    public struct DroneActions
    {
        private @InputControls m_Wrapper;
        public DroneActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @FlyTilt => m_Wrapper.m_Drone_FlyTilt;
        public InputAction @Ascend => m_Wrapper.m_Drone_Ascend;
        public InputAction @Descend => m_Wrapper.m_Drone_Descend;
        public InputAction @FlyRot => m_Wrapper.m_Drone_FlyRot;
        public InputAction @Escape => m_Wrapper.m_Drone_Escape;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void SetCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterface != null)
            {
                @FlyTilt.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnFlyTilt;
                @FlyTilt.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnFlyTilt;
                @FlyTilt.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnFlyTilt;
                @Ascend.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnAscend;
                @Ascend.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnAscend;
                @Ascend.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnAscend;
                @Descend.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnDescend;
                @Descend.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnDescend;
                @Descend.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnDescend;
                @FlyRot.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnFlyRot;
                @FlyRot.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnFlyRot;
                @FlyRot.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnFlyRot;
                @Escape.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FlyTilt.started += instance.OnFlyTilt;
                @FlyTilt.performed += instance.OnFlyTilt;
                @FlyTilt.canceled += instance.OnFlyTilt;
                @Ascend.started += instance.OnAscend;
                @Ascend.performed += instance.OnAscend;
                @Ascend.canceled += instance.OnAscend;
                @Descend.started += instance.OnDescend;
                @Descend.performed += instance.OnDescend;
                @Descend.canceled += instance.OnDescend;
                @FlyRot.started += instance.OnFlyRot;
                @FlyRot.performed += instance.OnFlyRot;
                @FlyRot.canceled += instance.OnFlyRot;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public DroneActions @Drone => new DroneActions(this);

    // ForkLift
    private readonly InputActionMap m_ForkLift;
    private IForkLiftActions m_ForkLiftActionsCallbackInterface;
    private readonly InputAction m_ForkLift_Move;
    private readonly InputAction m_ForkLift_LiftUp;
    private readonly InputAction m_ForkLift_LiftDown;
    private readonly InputAction m_ForkLift_Exit;
    public struct ForkLiftActions
    {
        private @InputControls m_Wrapper;
        public ForkLiftActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_ForkLift_Move;
        public InputAction @LiftUp => m_Wrapper.m_ForkLift_LiftUp;
        public InputAction @LiftDown => m_Wrapper.m_ForkLift_LiftDown;
        public InputAction @Exit => m_Wrapper.m_ForkLift_Exit;
        public InputActionMap Get() { return m_Wrapper.m_ForkLift; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ForkLiftActions set) { return set.Get(); }
        public void SetCallbacks(IForkLiftActions instance)
        {
            if (m_Wrapper.m_ForkLiftActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMove;
                @LiftUp.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftUp;
                @LiftUp.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftUp;
                @LiftUp.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftUp;
                @LiftDown.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftDown;
                @LiftDown.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftDown;
                @LiftDown.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftDown;
                @Exit.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_ForkLiftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @LiftUp.started += instance.OnLiftUp;
                @LiftUp.performed += instance.OnLiftUp;
                @LiftUp.canceled += instance.OnLiftUp;
                @LiftDown.started += instance.OnLiftDown;
                @LiftDown.performed += instance.OnLiftDown;
                @LiftDown.canceled += instance.OnLiftDown;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public ForkLiftActions @ForkLift => new ForkLiftActions(this);
    public interface IPlayerActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnHoldKey(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IDroneActions
    {
        void OnFlyTilt(InputAction.CallbackContext context);
        void OnAscend(InputAction.CallbackContext context);
        void OnDescend(InputAction.CallbackContext context);
        void OnFlyRot(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
    public interface IForkLiftActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLiftUp(InputAction.CallbackContext context);
        void OnLiftDown(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
}
