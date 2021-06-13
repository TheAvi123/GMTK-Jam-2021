using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Reference Variables
    [SerializeField] private Transform cameraTransform;

    // Configuration Parameters
    [SerializeField] private float minX = -32.0f;
    [SerializeField] private float maxX = +32.0f;
    [SerializeField] private float minZ = -36.0f;
    [SerializeField] private float maxZ = +36.0f;
    [SerializeField] private float minHeight = 1f;
    [SerializeField] private float maxHeight = 10f;
    [SerializeField] private float movementSpeed = 0.3f;
    [SerializeField] private float movementTime = 5f;
    [SerializeField] private float rotationSpeed = 3f;
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
        if (Input.GetMouseButton(1))
        {
            float mousex = Input.GetAxis("Mouse X");
            if (mousex != 0)
            {
                newRotation *= Quaternion.Euler(Vector3.up * rotationSpeed * mousex);
            }
        }
        // Zoom Inputs
        newZoom += new Vector3(0, Input.mouseScrollDelta.y, 0);

        // if (newZoom.y < minHeight)
        // {
        //     newZoom.y = minHeight;
        // }
        // if (newZoom.y > maxHeight)
        // {
        //     newZoom.y = maxHeight;
        // }

        newZoom.y = Mathf.Clamp(newZoom.y, minHeight, maxHeight);
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.z = Mathf.Clamp(newPosition.z, minZ, maxZ);

        // Update Transforms
        float lerpFactor = Time.deltaTime * movementTime;
        transform.position = Vector3.Lerp(transform.position, newPosition, lerpFactor);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, lerpFactor);
        cameraTransform.localPosition = Vector3.Lerp(cameraTransform.localPosition, newZoom, lerpFactor);
    }

    // Public Methods
}