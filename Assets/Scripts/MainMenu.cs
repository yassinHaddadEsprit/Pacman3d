using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level 0");
        Debug.Log("Start The Game");
    }

    public void StartTraining()
    {
        SceneManager.LoadScene("TrainingMode");
        Debug.Log("Start The Training");
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Main Menu");
    }


    public void Quit()
    {
        Application.Quit();
        Debug.Log("You Quit The Game");
    }
}
