using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    static public bool PauseGame;
    public GameObject pauseGameMenu;
    public GameObject bigheart;
    public GameObject smallheart;
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
        bigheart.SetActive(false);
        smallheart.SetActive(false);
        Time.timeScale = 1f;
        //AudioListener.pause = false;
        PauseGame = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        bigheart.SetActive(true);
        smallheart.SetActive(true);
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
    private void Hearts()
    {
        if (PauseGame == false)
        {

        }
    }

/*    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }*/
}
