// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player_Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player_Controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Controller"",
    ""maps"": [
        {
            ""name"": ""Click_Controller"",
            ""id"": ""69c785ff-dfe9-49b0-b2f9-53971edc9693"",
            ""actions"": [
                {
                    ""name"": ""SelectDestination"",
                    ""type"": ""Button"",
                    ""id"": ""06dca2b4-cb7d-4c65-a0e0-2af622fc78b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse_Position"",
                    ""type"": ""Value"",
                    ""id"": ""1fb6c7b5-67fc-4668-9a4a-9d1b2cf4647a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""Button"",
                    ""id"": ""2ce2f147-af54-4ad7-8a97-8d34d58e82e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraZoom"",
                    ""type"": ""Value"",
                    ""id"": ""aa62bb83-71b8-4734-9f5f-246584c3d7ef"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""086418c0-0337-46fd-a8f6-ae35daeb3d1c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectDestination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51512ba1-8b55-4f11-9fbe-e7e15186104e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse_Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b8bde2e-8139-4cec-ab74-94a0264d1c1c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21c47ee0-052d-4d19-a118-08e0e1e0941f"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraZoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Click_Controller
        m_Click_Controller = asset.FindActionMap("Click_Controller", throwIfNotFound: true);
        m_Click_Controller_SelectDestination = m_Click_Controller.FindAction("SelectDestination", throwIfNotFound: true);
        m_Click_Controller_Mouse_Position = m_Click_Controller.FindAction("Mouse_Position", throwIfNotFound: true);
        m_Click_Controller_CameraControl = m_Click_Controller.FindAction("CameraControl", throwIfNotFound: true);
        m_Click_Controller_CameraZoom = m_Click_Controller.FindAction("CameraZoom", throwIfNotFound: true);
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

    // Click_Controller
    private readonly InputActionMap m_Click_Controller;
    private IClick_ControllerActions m_Click_ControllerActionsCallbackInterface;
    private readonly InputAction m_Click_Controller_SelectDestination;
    private readonly InputAction m_Click_Controller_Mouse_Position;
    private readonly InputAction m_Click_Controller_CameraControl;
    private readonly InputAction m_Click_Controller_CameraZoom;
    public struct Click_ControllerActions
    {
        private @Player_Controller m_Wrapper;
        public Click_ControllerActions(@Player_Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @SelectDestination => m_Wrapper.m_Click_Controller_SelectDestination;
        public InputAction @Mouse_Position => m_Wrapper.m_Click_Controller_Mouse_Position;
        public InputAction @CameraControl => m_Wrapper.m_Click_Controller_CameraControl;
        public InputAction @CameraZoom => m_Wrapper.m_Click_Controller_CameraZoom;
        public InputActionMap Get() { return m_Wrapper.m_Click_Controller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Click_ControllerActions set) { return set.Get(); }
        public void SetCallbacks(IClick_ControllerActions instance)
        {
            if (m_Wrapper.m_Click_ControllerActionsCallbackInterface != null)
            {
                @SelectDestination.started -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnSelectDestination;
                @SelectDestination.performed -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnSelectDestination;
                @SelectDestination.canceled -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnSelectDestination;
                @Mouse_Position.started -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnMouse_Position;
                @Mouse_Position.performed -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnMouse_Position;
                @Mouse_Position.canceled -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnMouse_Position;
                @CameraControl.started -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnCameraControl;
                @CameraZoom.started -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.performed -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.canceled -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnCameraZoom;
            }
            m_Wrapper.m_Click_ControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SelectDestination.started += instance.OnSelectDestination;
                @SelectDestination.performed += instance.OnSelectDestination;
                @SelectDestination.canceled += instance.OnSelectDestination;
                @Mouse_Position.started += instance.OnMouse_Position;
                @Mouse_Position.performed += instance.OnMouse_Position;
                @Mouse_Position.canceled += instance.OnMouse_Position;
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
                @CameraZoom.started += instance.OnCameraZoom;
                @CameraZoom.performed += instance.OnCameraZoom;
                @CameraZoom.canceled += instance.OnCameraZoom;
            }
        }
    }
    public Click_ControllerActions @Click_Controller => new Click_ControllerActions(this);
    public interface IClick_ControllerActions
    {
        void OnSelectDestination(InputAction.CallbackContext context);
        void OnMouse_Position(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
        void OnCameraZoom(InputAction.CallbackContext context);
    }
}
