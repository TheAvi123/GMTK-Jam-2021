using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Reference Variables
    [SerializeField] private Transform cameraTransform;
    
    // Configuration Parameters
    [SerializeField] private float movementSpeed = 1f;
    [SerializeField] private float movementTime = 5f;
    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private Vector3 zoomSpeed;
    
    // State Variables
    private Vector3 newPosition;
    private Quaternion newRotation;
    private Vector3 newZoom;
    
    // Internal Methods
    private void Start() {
        InitializeNewTransforms();
    }

    private void InitializeNewTransforms() {
        newPosition = transform.position;
        newRotation = transform.rotation;
        newZoom = cameraTransform.localPosition;
    }

    void Update() {
        HandleUserInput();
    }

    private void HandleUserInput() {
        // Positional Inputs
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            newPosition += transform.forward * movementSpeed;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            newPosition += transform.forward * -movementSpeed;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            newPosition += transform.right * -movementSpeed;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            newPosition += transform.right * movementSpeed;
        }
        // Rotational Inputs
        if (Input.GetKey(KeyCode.Q)) {
            newRotation *= Quaternion.Euler(Vector3.up * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.E)) {
            newRotation *= Quaternion.Euler(Vector3.up * -rotationSpeed);
        }
        // Zoom Inputs
        if (Input.GetKey(KeyCode.R)) {
            newZoom += zoomSpeed;
        } 
        if (Input.GetKey(KeyCode.F)) {
            newZoom -= zoomSpeed;
        } 
        // Update Transforms
        float lerpFactor = Time.deltaTime * movementTime;
        transform.position = Vector3.Lerp(transform.position, newPosition, lerpFactor);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, lerpFactor);
        cameraTransform.localPosition = Vector3.Lerp(cameraTransform.localPosition, newZoom, lerpFactor);
    }

    // Public Methods
}