using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    static public bool PauseGame;
    public GameObject pauseGameMenu;
    private void Awake()
    {
       PauseGame = false;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        //AudioListener.pause = false;
        PauseGame = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        //AudioListener.pause = true;
        PauseGame = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        ADSceneLoader.LoadScene(0);

    }

/*    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }*/
}
