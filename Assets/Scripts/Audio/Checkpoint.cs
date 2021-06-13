using UnityEngine;

public class Checkpoint : MonoBehaviour 
{
    // Reference Variables
    private AudioManager audioManager;

    // Configuration Parameters
    
    // State Variables
    [SerializeField] private bool checkpointReached = false;

    // Internal Methods
    private void Start() {
        FindAudioManager();
    }

    private void FindAudioManager() {
        audioManager = FindObjectOfType<AudioManager>();
        if (!audioManager) {
            Debug.LogError("No AudioManager Found in Scene!");
            gameObject.SetActive(false);
        }
    }

    // Public Methods
    public void SetCheckpointReached() {
        checkpointReached = true;
    }

    public bool GetCheckpointStatus() {
        return checkpointReached;
    }
}
