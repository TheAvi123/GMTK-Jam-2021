using System;

using Systems;

using UnityEngine;

public class MenuController : MonoBehaviour 
{
    // Reference Variables
    private GameStateManager gameStateManager;
    
    // Internal Methods
    private void Start() {
        FindGameStateManager();
    }

    private void FindGameStateManager() {
        gameStateManager = FindObjectOfType<GameStateManager>();
        if (!gameStateManager) {
            Debug.LogError("No GameStateManager Found in Scene!");
            gameObject.SetActive(false);
        }
    }

    void Update() {
        CheckForInput();
    }

    private void CheckForInput() {
        if (Input.anyKey) {
            gameStateManager.LoadTutorial();
        }
    }   

    // Public Methods
}
