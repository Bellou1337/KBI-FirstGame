using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class MainADScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitOpenAD());
    }

    public void AfterCloseAD()
    {
        Debug.Log("Clodesfserhdthrgse");
        StartCoroutine(WaitOpenFinishScene());
    }

    IEnumerator WaitOpenAD()
    {
        yield return new WaitForSeconds(1.0f);
        YandexGame.FullscreenShow();
    }

    IEnumerator WaitOpenFinishScene()
    {
        yield return new WaitForSeconds(0.5f);
        ADSceneLoader.LoadFinishScene();
    }
}
