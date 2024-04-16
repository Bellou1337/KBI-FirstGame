using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using YG.Utils.LB;

public class LeaderboardController : MonoBehaviour
{
    public LeaderboardYG LBYG;
    void Awake()
    {
        LBYG.NewScore(132);
        LBYG.UpdateLB();
        /*Debug.Log("fersg");

        YandexGame.GetLeaderboard("MaxResult", 10, 10, 10, "Small");
        LBData a = new LBData();
        YandexGame.onGetLeaderboard(a);

        Debug.Log(a.ToString());*/
    }
}
