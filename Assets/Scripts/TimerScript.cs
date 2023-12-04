using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float TimeLeft;
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        if(TimeLeft > 0) {
            TimeLeft -= Time.deltaTime;
        }
        else {
            TimeLeft = 0;
        }
        DisplayTime(TimeLeft);
    }

    void DisplayTime(float currentTime) {
        if (currentTime < 0) {
            currentTime = 0;
        }

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
