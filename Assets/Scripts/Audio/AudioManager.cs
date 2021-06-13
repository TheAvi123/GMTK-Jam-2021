using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Reference Variables

    // Configuration Parameters
    [Header("Audio Files")] 
    [SerializeField] private float loopDuration = 0.0f;
    [SerializeField] private AudioSource[] checkpointBuildings;

    // State Variables
    private float ticker;

    // Internal Methods
    void Update() {
        IncreaseTicker();
    }

    private void IncreaseTicker() {
        ticker -= Time.deltaTime;
        if (ticker <= 0.0f) {
            foreach (AudioSource audioSource in checkpointBuildings) {
                Checkpoint checkpoint = audioSource.GetComponent<Checkpoint>();
                if (!checkpoint) {
                    Debug.LogError("No Checkpoint Script Found on Checkpoint Building.");
                    gameObject.SetActive(false);
                }
                if (checkpoint.GetCheckpointStatus()) {
                    audioSource.Play();
                }
            }

            ticker = loopDuration;
        }
    }

    // Public Methods
}
