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
        PauseGame = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        bigheart.SetActive(true);
        smallheart.SetActive(true);

        Time.timeScale = 0f;
        PauseGame = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        ADSceneLoader.LoadScene(0);

    }
}
