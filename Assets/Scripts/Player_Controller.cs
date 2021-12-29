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
                    ""name"": ""Click"",
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
                    ""action"": ""Click"",
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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Click_Controller
        m_Click_Controller = asset.FindActionMap("Click_Controller", throwIfNotFound: true);
        m_Click_Controller_Click = m_Click_Controller.FindAction("Click", throwIfNotFound: true);
        m_Click_Controller_Mouse_Position = m_Click_Controller.FindAction("Mouse_Position", throwIfNotFound: true);
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
    private readonly InputAction m_Click_Controller_Click;
    private readonly InputAction m_Click_Controller_Mouse_Position;
    public struct Click_ControllerActions
    {
        private @Player_Controller m_Wrapper;
        public Click_ControllerActions(@Player_Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Click_Controller_Click;
        public InputAction @Mouse_Position => m_Wrapper.m_Click_Controller_Mouse_Position;
        public InputActionMap Get() { return m_Wrapper.m_Click_Controller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Click_ControllerActions set) { return set.Get(); }
        public void SetCallbacks(IClick_ControllerActions instance)
        {
            if (m_Wrapper.m_Click_ControllerActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnClick;
                @Mouse_Position.started -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnMouse_Position;
                @Mouse_Position.performed -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnMouse_Position;
                @Mouse_Position.canceled -= m_Wrapper.m_Click_ControllerActionsCallbackInterface.OnMouse_Position;
            }
            m_Wrapper.m_Click_ControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Mouse_Position.started += instance.OnMouse_Position;
                @Mouse_Position.performed += instance.OnMouse_Position;
                @Mouse_Position.canceled += instance.OnMouse_Position;
            }
        }
    }
    public Click_ControllerActions @Click_Controller => new Click_ControllerActions(this);
    public interface IClick_ControllerActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnMouse_Position(InputAction.CallbackContext context);
    }
}
