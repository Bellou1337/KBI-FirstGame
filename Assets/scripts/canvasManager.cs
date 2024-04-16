using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UIElements;

public class canvasManager : MonoBehaviour
{
    public TextMeshProUGUI max_res_text;
    public TextMeshProUGUI timer_text;
    public TextMeshProUGUI miss_text;
    public TextMeshProUGUI count_text;
    public int count = 0;
    public int miss = 0;
    public float timer = 60;
    int time_int;
    int max_res = 0;

    void Start()
    {
        count_text.text = "Попаданий: " + count.ToString();
        miss_text.text = "Промахов: " + miss.ToString();
        max_res_text.text = "Макс результат: 0";
        timer_text.text = "Время: " + timer.ToString();
    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            time_int = (int)timer;
            timer_text.text = "Время: " + time_int.ToString();
        }
        else
        {
            max_res = Math.Max(count - miss, max_res);
            count = 0;
            count_text.text = "Попаданий: 0";

            miss = 0;
            miss_text.text = "Промахов: 0";

            max_res_text.text = "Макс результат: " + max_res;

            timer = 60;
        }
    }
    public void add_miss()
    {
        miss++;
        miss_text.text = "Промахов: " + miss.ToString();
    }

    public void add_count()
    {
        count++;
        count_text.text = "Попаданий: " + count.ToString();
    }
}
