// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class InputManager : MonoBehaviour
// {
//     private static InputManager _instance;
//
//     public static InputManager Instance
//     {
//         get
//         {
//             return _instance;
//         }
//     }
//
//     private PlayerControls playerControls;
//
//     private void Awake()
//     {
//         if(_instance!=null&& _instance != this)
//         {
//             Destroy(this.gameObject);
//         }
//         else
//         {
//             _instance = this;
//         }
//         playerControls = new PlayerControls();
//     }
//     private void OnEnable()
//     {
//         playerControls.Enable();
//     }
//     private void OnDisable()
//     {
//         playerControls.Disable();
//     }
//
//     public Vector2 GetPlayerMovement()
//     {
//         return playerControls.PlayerCamera.Movement.ReadValue<Vector2>();
//     }
//     public Vector2 GetMouseDelta()
//     {
//         return playerControls.PlayerCamera.Rotate.ReadValue<Vector2>();
//     }
//     public Vector2 GetScrollWheel()
//     {
//         return playerControls.PlayerCamera.Zoom.ReadValue<Vector2>();
//     }
// }
