using UnityEngine;

public class BridgeGenerator : MonoBehaviour 
{
    // Reference Variables

    // Configuration Parameters
    [SerializeField] private float bridgePieceLength;
    [SerializeField] private GameObject bridgePiece;
    
    [SerializeField] private GameObject buildingA;
    [SerializeField] private GameObject buildingB;
    
    // State Variables
    private Vector3 positionA;
    private Vector3 positionB;

    // Internal Methods
    void Update() {
        if (buildingA && buildingB) {
            BuildBridge();
            buildingA = null;
            buildingB = null;
        }
    }

    public void BuildBridge() {
        positionA = buildingA.transform.position;
        positionB = buildingB.transform.position;
        Vector3 bridgeVector = positionB - positionA;
        Vector3 direction = bridgeVector.normalized;
        float bridgeLength = bridgeVector.magnitude;

        Vector3 currentPosition = positionA;
        // currentPosition += direction * bridgePieceLength / 2;
        // bridgeLength -= bridgePieceLength / 2;

        while (bridgeLength > bridgePieceLength) {
            currentPosition += direction * bridgePieceLength;
            currentPosition.y = 0;
            bridgeLength -= bridgePieceLength;
            SpawnBridgeSegment(currentPosition, direction);
        }
    }

    private void SpawnBridgeSegment(Vector3 position, Vector3 rotation) {
        Instantiate(bridgePiece, position, Quaternion.LookRotation(rotation));
    }

    // Public Methods
}
