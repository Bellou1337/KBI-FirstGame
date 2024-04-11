using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMenedger : MonoBehaviour
{
    public bool isOpenSettings = false;
    public GameObject[] SettingsObj;

    private void Awake()
    {
        foreach (GameObject obj in SettingsObj)
        {
            obj.SetActive(isOpenSettings);
        }
    }

    private void leaders()
    {

    }
    public void PlayGame(int i)
    {
        SceneManager.LoadScene(i);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Was Exit");
    }

    public void UseSettings()
    {
        isOpenSettings = !isOpenSettings;

        foreach (GameObject obj in SettingsObj)
        {
            obj.SetActive(isOpenSettings);
        }
        
    }
}
