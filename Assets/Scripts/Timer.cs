using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool isRunning = true;
    public TMP_Text timeText;
    public InputField champTexte;

    void Start()
    {
        isRunning = true;

}

    void Update()
    {
        if (isRunning) {
            if (timeRemaining > -1)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }
    }
    void DisplayTime(float time)
    {
        time += 1;
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }


}