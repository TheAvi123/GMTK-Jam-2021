using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Systems {
    public class GameStateManager : MonoBehaviour
    {
        public static GameStateManager sharedInstance;

        private enum GameState {Null, Menu, Tutorial, Level1, GameOver};

        [Header("Scene Names")]
        [SerializeField] string menuSceneName     = null;
        [SerializeField] string tutorialSceneName = null;
        [SerializeField] string level1SceneName   = null;
        [SerializeField] string gameOverSceneName = null;

        //Configuration Parameters
        [Header("Configuration")]
        [SerializeField] bool startFromInitialState = true;
        [SerializeField] GameState initialState = GameState.Menu;

        //State Variables
        private GameState currentState;
        
        //Internal Methods
        private void Awake() {
            SetSharedInstance();
            SetCurrentState();
            LoadInitialState();
        }

        [SuppressMessage("ReSharper", "UnusedMember.Local")]
        private void OnSceneChange() {
            SetCurrentState();
        }   //Called from Singleton

        private void SetSharedInstance() {
            sharedInstance = this;
        }

        private void SetCurrentState() {
            currentState = SceneNameToState(SceneManager.GetActiveScene());
        }

        public void LoadInitialState() {
            if (startFromInitialState && currentState != initialState) {
                currentState = initialState;
                SceneManager.LoadScene(StateToName(initialState));
            }
        }
        
        //Helper Methods
        private string StateToName(GameState state) {
            switch (state) {
                case GameState.Menu:
                    return menuSceneName;
                case GameState.Tutorial:
                    return tutorialSceneName;
                case GameState.Level1:
                    return level1SceneName;
                case GameState.GameOver:
                    return gameOverSceneName;
                default:
                    Debug.LogError("Game State " + state.ToString() + " Does Not Exist");
                    return null;
            }
        }

        private GameState SceneNameToState(Scene scene) {
            string sceneName = scene.name;
            if (sceneName == menuSceneName) {
                return GameState.Menu;
            } else if (sceneName == gameOverSceneName) {
                return GameState.GameOver;
            } else if (sceneName == tutorialSceneName) {
                return GameState.Tutorial;
            } else if (sceneName == level1SceneName) {
                return GameState.Level1;
            } else {
                Debug.LogError("Scene " + scene.name + " Does Not Exist in GameState Enumeration");
                return GameState.Null;
            }
        }

        private void LoadState(GameState state) {
            SceneManager.LoadScene(StateToName(state));
        }
        
        //Load Methods
        public void LoadStartMenu() {
            LoadState(GameState.Menu);
        }

        public void GameOver(float delayInSeconds) {
            LoadState(GameState.GameOver);
        }
        
        public void LoadTutorial() {
            LoadState(GameState.Tutorial);
        }

        public void LoadLevel1() {
            LoadState(GameState.Level1);
        }
        
        public void QuitGame() {
            Debug.Log("Exiting Game...");
            Application.Quit();
        }

        //Public Methods
        public string GetCurrentScene() {
            return SceneManager.GetActiveScene().name;
        }
    }
}