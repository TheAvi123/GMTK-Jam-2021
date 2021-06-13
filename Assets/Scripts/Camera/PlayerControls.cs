// // GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'
//
// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine.InputSystem;
// using UnityEngine.InputSystem.Utilities;
//
// public class @PlayerControls : IInputActionCollection, IDisposable
// {
//     public InputActionAsset asset { get; }
//     public @PlayerControls()
//     {
//         asset = InputActionAsset.FromJson(@"{
//     ""name"": ""PlayerControls"",
//     ""maps"": [
//         {
//             ""name"": ""Player/Camera"",
//             ""id"": ""ac21914d-a77a-4100-8e3c-6b67e4531157"",
//             ""actions"": [
//                 {
//                     ""name"": ""Movement"",
//                     ""type"": ""PassThrough"",
//                     ""id"": ""73c0e65a-add6-42df-b48e-5af1fb3fddfa"",
//                     ""expectedControlType"": ""Vector2"",
//                     ""processors"": """",
//                     ""interactions"": """"
//                 },
//                 {
//                     ""name"": ""Rotate"",
//                     ""type"": ""PassThrough"",
//                     ""id"": ""31ba6840-b8b7-4477-b4c8-2c13511dd0ca"",
//                     ""expectedControlType"": ""Button"",
//                     ""processors"": """",
//                     ""interactions"": """"
//                 },
//                 {
//                     ""name"": ""Zoom"",
//                     ""type"": ""PassThrough"",
//                     ""id"": ""4dfe9b2a-6861-4e0e-8485-06073f8d7ca8"",
//                     ""expectedControlType"": ""Button"",
//                     ""processors"": """",
//                     ""interactions"": """"
//                 }
//             ],
//             ""bindings"": [
//                 {
//                     ""name"": ""WASD"",
//                     ""id"": ""c584e8a9-73f4-48e5-80d3-c60a54922823"",
//                     ""path"": ""2DVector"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Movement"",
//                     ""isComposite"": true,
//                     ""isPartOfComposite"": false
//                 },
//                 {
//                     ""name"": ""up"",
//                     ""id"": ""f944c133-4721-450f-9bb9-5a07426ef74d"",
//                     ""path"": ""<Keyboard>/w"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Movement"",
//                     ""isComposite"": false,
//                     ""isPartOfComposite"": true
//                 },
//                 {
//                     ""name"": ""down"",
//                     ""id"": ""7b045d7d-61bf-4c0b-b8d2-2677b6397bf8"",
//                     ""path"": ""<Keyboard>/s"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Movement"",
//                     ""isComposite"": false,
//                     ""isPartOfComposite"": true
//                 },
//                 {
//                     ""name"": ""left"",
//                     ""id"": ""456457c0-d4ec-40af-81bc-e39b07292df7"",
//                     ""path"": ""<Keyboard>/a"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Movement"",
//                     ""isComposite"": false,
//                     ""isPartOfComposite"": true
//                 },
//                 {
//                     ""name"": ""right"",
//                     ""id"": ""7a730558-ed1d-4d09-8f9f-9402582720a0"",
//                     ""path"": ""<Keyboard>/d"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Movement"",
//                     ""isComposite"": false,
//                     ""isPartOfComposite"": true
//                 },
//                 {
//                     ""name"": ""Button With One Modifier"",
//                     ""id"": ""7ce23614-2093-493a-88c6-669c52a3d6c0"",
//                     ""path"": ""ButtonWithOneModifier"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Rotate"",
//                     ""isComposite"": true,
//                     ""isPartOfComposite"": false
//                 },
//                 {
//                     ""name"": ""button"",
//                     ""id"": ""0de5853a-724e-422f-b3b5-37d750903e46"",
//                     ""path"": ""<Mouse>/rightButton"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Rotate"",
//                     ""isComposite"": false,
//                     ""isPartOfComposite"": true
//                 },
//                 {
//                     ""name"": ""modifier"",
//                     ""id"": ""d598d57d-7cce-4c4a-b35c-a80cb83f8f55"",
//                     ""path"": ""<Mouse>/position/x"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Rotate"",
//                     ""isComposite"": false,
//                     ""isPartOfComposite"": true
//                 },
//                 {
//                     ""name"": ""Button With One Modifier"",
//                     ""id"": ""daf8c832-e5ef-48a6-bdc6-5573f2835abf"",
//                     ""path"": ""ButtonWithOneModifier"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Zoom"",
//                     ""isComposite"": true,
//                     ""isPartOfComposite"": false
//                 },
//                 {
//                     ""name"": ""button"",
//                     ""id"": ""dafdbeac-f48d-4fcb-87be-864d1dab0f32"",
//                     ""path"": ""<Mouse>/scroll"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Zoom"",
//                     ""isComposite"": false,
//                     ""isPartOfComposite"": true
//                 },
//                 {
//                     ""name"": ""modifier"",
//                     ""id"": ""a6e81fb5-e2a8-416c-a620-4de73f856805"",
//                     ""path"": ""<Mouse>/scroll/x"",
//                     ""interactions"": """",
//                     ""processors"": """",
//                     ""groups"": """",
//                     ""action"": ""Zoom"",
//                     ""isComposite"": false,
//                     ""isPartOfComposite"": true
//                 }
//             ]
//         }
//     ],
//     ""controlSchemes"": []
// }");
//         // Player/Camera
//         m_PlayerCamera = asset.FindActionMap("Player/Camera", throwIfNotFound: true);
//         m_PlayerCamera_Movement = m_PlayerCamera.FindAction("Movement", throwIfNotFound: true);
//         m_PlayerCamera_Rotate = m_PlayerCamera.FindAction("Rotate", throwIfNotFound: true);
//         m_PlayerCamera_Zoom = m_PlayerCamera.FindAction("Zoom", throwIfNotFound: true);
//     }
//
//     public void Dispose()
//     {
//         UnityEngine.Object.Destroy(asset);
//     }
//
//     public InputBinding? bindingMask
//     {
//         get => asset.bindingMask;
//         set => asset.bindingMask = value;
//     }
//
//     public ReadOnlyArray<InputDevice>? devices
//     {
//         get => asset.devices;
//         set => asset.devices = value;
//     }
//
//     public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;
//
//     public bool Contains(InputAction action)
//     {
//         return asset.Contains(action);
//     }
//
//     public IEnumerator<InputAction> GetEnumerator()
//     {
//         return asset.GetEnumerator();
//     }
//
//     IEnumerator IEnumerable.GetEnumerator()
//     {
//         return GetEnumerator();
//     }
//
//     public void Enable()
//     {
//         asset.Enable();
//     }
//
//     public void Disable()
//     {
//         asset.Disable();
//     }
//
//     // Player/Camera
//     private readonly InputActionMap m_PlayerCamera;
//     private IPlayerCameraActions m_PlayerCameraActionsCallbackInterface;
//     private readonly InputAction m_PlayerCamera_Movement;
//     private readonly InputAction m_PlayerCamera_Rotate;
//     private readonly InputAction m_PlayerCamera_Zoom;
//     public struct PlayerCameraActions
//     {
//         private @PlayerControls m_Wrapper;
//         public PlayerCameraActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
//         public InputAction @Movement => m_Wrapper.m_PlayerCamera_Movement;
//         public InputAction @Rotate => m_Wrapper.m_PlayerCamera_Rotate;
//         public InputAction @Zoom => m_Wrapper.m_PlayerCamera_Zoom;
//         public InputActionMap Get() { return m_Wrapper.m_PlayerCamera; }
//         public void Enable() { Get().Enable(); }
//         public void Disable() { Get().Disable(); }
//         public bool enabled => Get().enabled;
//         public static implicit operator InputActionMap(PlayerCameraActions set) { return set.Get(); }
//         public void SetCallbacks(IPlayerCameraActions instance)
//         {
//             if (m_Wrapper.m_PlayerCameraActionsCallbackInterface != null)
//             {
//                 @Movement.started -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnMovement;
//                 @Movement.performed -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnMovement;
//                 @Movement.canceled -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnMovement;
//                 @Rotate.started -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnRotate;
//                 @Rotate.performed -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnRotate;
//                 @Rotate.canceled -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnRotate;
//                 @Zoom.started -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnZoom;
//                 @Zoom.performed -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnZoom;
//                 @Zoom.canceled -= m_Wrapper.m_PlayerCameraActionsCallbackInterface.OnZoom;
//             }
//             m_Wrapper.m_PlayerCameraActionsCallbackInterface = instance;
//             if (instance != null)
//             {
//                 @Movement.started += instance.OnMovement;
//                 @Movement.performed += instance.OnMovement;
//                 @Movement.canceled += instance.OnMovement;
//                 @Rotate.started += instance.OnRotate;
//                 @Rotate.performed += instance.OnRotate;
//                 @Rotate.canceled += instance.OnRotate;
//                 @Zoom.started += instance.OnZoom;
//                 @Zoom.performed += instance.OnZoom;
//                 @Zoom.canceled += instance.OnZoom;
//             }
//         }
//     }
//     public PlayerCameraActions @PlayerCamera => new PlayerCameraActions(this);
//     public interface IPlayerCameraActions
//     {
//         void OnMovement(InputAction.CallbackContext context);
//         void OnRotate(InputAction.CallbackContext context);
//         void OnZoom(InputAction.CallbackContext context);
//     }
// }
