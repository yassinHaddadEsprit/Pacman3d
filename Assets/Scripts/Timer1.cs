using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer1 : MonoBehaviour
{
    public float timeRemaining = 30f;
    public bool isRunning = true;
    public TMP_Text timeText;

    void Start()
    {
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                SceneManager.LoadScene("LostLevel0");
                Debug.Log("Time Out");
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