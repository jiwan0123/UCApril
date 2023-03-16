using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int Min;
    float Sec;
    float second;
    bool isTimeUpdate = true;

    public Text TimerText;

    void Start()
    {
        second = Min * 60;
    }

    public void Update()
    {

        if (isTimeUpdate)
        {
            TimerGo();
        }

    }

    void TimerGo()
    {

        Sec = (int)second % 60;
        Min = (int)second / 60;

        second -= Time.deltaTime;

        TimerText.text = $"{Min}:{Sec}";

        if (second < 0)
            isTimeUpdate = false;

    }

}
