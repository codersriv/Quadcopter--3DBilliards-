// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""a422bcd4-9153-497f-8689-a9f3ffc1b5eb"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""be2ec9da-eadc-4b76-9229-6ed4b4e9cd8b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""8fdcb7dd-b1fd-4696-b017-7d5ca241bf9e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f615aca9-d659-4319-976f-2fa86e64a0ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""33a9406f-e8d8-4e90-8581-95b95fe28f56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8a4b7675-68e1-4e85-ba7b-6443bfbeb2fa"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0613554a-d1b4-4df0-af15-76abfcf2749c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""df3b043e-668a-407e-adf2-bc601d8bcf38"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9e58c634-b43c-4863-ada2-6a098033cc94"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""85035dec-6a99-4ad0-994d-a4b50afc9473"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b54e6171-2378-4e71-bf28-1340acb1bde1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c377bbc-4c0b-4c66-9c8f-4cc0c6150c9f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdba5b17-165c-420d-a37c-072e4c597761"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""b65107d6-1c47-4959-816c-0ff84b3464bd"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""f09cf475-b6ed-415a-886e-f1890f3704ff"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""57a4e1f7-efd6-4b51-9e28-c1877ac3882d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""New action map"",
            ""id"": ""45a2c795-1205-4c51-bc59-d27ce74fe94a"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""e965c00e-3c74-4139-816f-3933d8f74f11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""61c3254a-09eb-4b2e-929c-0116ab4a93e1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""New action map1"",
            ""id"": ""66af7bf7-903e-4b38-b45b-30034818049c"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""9ff58acd-c736-4a43-a64b-407ca339af83"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4644899a-1d16-49ef-9fb7-7643c16c43e0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Movement = m_Move.FindAction("Movement", throwIfNotFound: true);
        m_Move_Look = m_Move.FindAction("Look", throwIfNotFound: true);
        m_Move_Shoot = m_Move.FindAction("Shoot", throwIfNotFound: true);
        m_Move_Newaction = m_Move.FindAction("New action", throwIfNotFound: true);
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_Newaction = m_Newactionmap.FindAction("New action", throwIfNotFound: true);
        // New action map1
        m_Newactionmap1 = asset.FindActionMap("New action map1", throwIfNotFound: true);
        m_Newactionmap1_Newaction = m_Newactionmap1.FindAction("New action", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Movement;
    private readonly InputAction m_Move_Look;
    private readonly InputAction m_Move_Shoot;
    private readonly InputAction m_Move_Newaction;
    public struct MoveActions
    {
        private @PlayerInput m_Wrapper;
        public MoveActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Move_Movement;
        public InputAction @Look => m_Wrapper.m_Move_Look;
        public InputAction @Shoot => m_Wrapper.m_Move_Shoot;
        public InputAction @Newaction => m_Wrapper.m_Move_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnLook;
                @Shoot.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnShoot;
                @Newaction.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private INewactionmapActions m_NewactionmapActionsCallbackInterface;
    private readonly InputAction m_Newactionmap_Newaction;
    public struct NewactionmapActions
    {
        private @PlayerInput m_Wrapper;
        public NewactionmapActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Newactionmap_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void SetCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_NewactionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);

    // New action map1
    private readonly InputActionMap m_Newactionmap1;
    private INewactionmap1Actions m_Newactionmap1ActionsCallbackInterface;
    private readonly InputAction m_Newactionmap1_Newaction;
    public struct Newactionmap1Actions
    {
        private @PlayerInput m_Wrapper;
        public Newactionmap1Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Newactionmap1_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Newactionmap1Actions set) { return set.Get(); }
        public void SetCallbacks(INewactionmap1Actions instance)
        {
            if (m_Wrapper.m_Newactionmap1ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_Newactionmap1ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_Newactionmap1ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_Newactionmap1ActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_Newactionmap1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public Newactionmap1Actions @Newactionmap1 => new Newactionmap1Actions(this);
    public interface IMoveActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface INewactionmapActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface INewactionmap1Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
