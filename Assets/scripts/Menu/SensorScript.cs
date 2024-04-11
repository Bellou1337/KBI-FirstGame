using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensorScript : MonoBehaviour
{
    public Slider LevelSensor;
    public Slider LevelVolume;
    private void Start()
    {
        LevelSensor.value = SettingsManager.instance.Sensor;
        LevelVolume.value = SettingsManager.instance.Volume;

    }
    private void Update()
    {
        SettingsManager.instance.Volume = LevelVolume.value;
        SettingsManager.instance.Sensor = LevelSensor.value;
    }
}
