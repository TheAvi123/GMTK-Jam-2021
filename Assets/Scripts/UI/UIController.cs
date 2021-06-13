using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    GameObject title;
    GameObject hud;
    GameObject pauseScreen;
    GameObject world;
    GameObject camSys;

    private void Start()
    {
        title = GameObject.Find("Title");
        hud = GameObject.Find("Hud");
        pauseScreen = GameObject.Find("Pause");
        world = GameObject.Find("World");
        camSys = GameObject.Find("Camera System");
        hud.SetActive(false);
        pauseScreen.SetActive(false);
    }

    void Update()
    {
        if (title.activeSelf)
        {
            if (Input.anyKey)
            {
                camSys.transform.position = new Vector3(camSys.transform.position.x, camSys.transform.position.y-1, camSys.transform.position.z);
                title.SetActive(false);
                world.SetActive(true);
            }
        }
        else if (pauseScreen.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape) | Input.GetKeyDown(KeyCode.P))
            {
                pauseScreen.SetActive(false);
                hud.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape) | Input.GetKeyDown(KeyCode.P))
            {
                pauseScreen.SetActive(true);
                hud.SetActive(false);
            }
        }
    }
    public void Continue()
    {
        pauseScreen.SetActive(false);
        hud.SetActive(true);
    }
    public void RestartGame()
    {
        //todo restart worldmap
        pauseScreen.SetActive(false);
        hud.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
