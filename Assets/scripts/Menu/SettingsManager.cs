using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager instance = null;
    public float Volume = 7;
    public float Sensor = 5;

    private void Awake()
    {
        if (instance == null) { instance = this; }
        else Destroy(gameObject);

        SaveController.LoadData();

        DontDestroyOnLoad(gameObject);
        InitializeSettingsManger();
    }
    private void InitializeSettingsManger()
    {

    }

}
