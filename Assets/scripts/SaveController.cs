using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

static public class SaveController
{
    public static void SaveData()
    {
        YandexGame.savesData.Volume = SettingsManager.instance.Volume;
        YandexGame.savesData.Sensor = SettingsManager.instance.Sensor;
        YandexGame.savesData.max_result = canvasManager.max_res;

        YandexGame.SaveProgress();
    }

    public static void LoadData()
    {
        SettingsManager.instance.Volume = YandexGame.savesData.Volume;
        SettingsManager.instance.Sensor = YandexGame.savesData.Sensor;
        canvasManager.max_res = YandexGame.savesData.max_result;
    }
}
