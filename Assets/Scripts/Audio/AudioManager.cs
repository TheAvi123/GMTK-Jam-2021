using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Reference Variables

    // Configuration Parameters
    [Header("Audio Files")] 
    [SerializeField] private int checkpointCount = 0;
    [SerializeField] private AudioClip[] checkpointAudioClips;
    [SerializeField] private GameObject[] checkpointBuildings;

    // State Variables
    private bool[] checkpointStatus;

    // Internal Methods
    private void Start() {
        CheckArraySizes();
        InitializeCheckpointStatusArray();
    }

    private void CheckArraySizes() {
        if (checkpointAudioClips.Length != checkpointCount) {
            Debug.LogError("Number of Audio Clips does not match checkpoint Count");
        }
        if (checkpointBuildings.Length != checkpointCount) {
            Debug.LogError("Number of Checkpoint Buildings does not match checkpoint Count");
        }
    }

    private void InitializeCheckpointStatusArray() {
        checkpointStatus = new bool[checkpointCount];
    }

    void Update() {
        
    }

    // Public Methods
}
