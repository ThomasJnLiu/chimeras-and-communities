// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""fc1b57d6-d2c1-4559-b332-534c4884b7ce"",
            ""actions"": [
                {
                    ""name"": ""OpenMap"",
                    ""type"": ""Button"",
                    ""id"": ""49a1d0ce-96c0-419f-b76c-4d6b81dbddb8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""CloseMap"",
                    ""type"": ""Button"",
                    ""id"": ""01c386d6-45fa-46d3-ac62-691a596a2759"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""24be3fa0-9a84-400b-a879-8c422e9f7302"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9653951-69a3-404b-8914-0e6e56218164"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseMap"",
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
        m_Player_OpenMap = m_Player.FindAction("OpenMap", throwIfNotFound: true);
        m_Player_CloseMap = m_Player.FindAction("CloseMap", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_OpenMap;
    private readonly InputAction m_Player_CloseMap;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenMap => m_Wrapper.m_Player_OpenMap;
        public InputAction @CloseMap => m_Wrapper.m_Player_CloseMap;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @OpenMap.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpenMap;
                @OpenMap.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpenMap;
                @OpenMap.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpenMap;
                @CloseMap.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCloseMap;
                @CloseMap.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCloseMap;
                @CloseMap.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCloseMap;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenMap.started += instance.OnOpenMap;
                @OpenMap.performed += instance.OnOpenMap;
                @OpenMap.canceled += instance.OnOpenMap;
                @CloseMap.started += instance.OnCloseMap;
                @CloseMap.performed += instance.OnCloseMap;
                @CloseMap.canceled += instance.OnCloseMap;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnOpenMap(InputAction.CallbackContext context);
        void OnCloseMap(InputAction.CallbackContext context);
    }
}
