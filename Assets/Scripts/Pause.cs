using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f; // Arrête le temps pour mettre en pause le jeu
        isPaused = true;
        SceneManager.LoadScene("PauseLevel0");

    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Réactive le temps pour reprendre le jeu
        isPaused = false;
        SceneManager.LoadScene("Level0");

    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Main Menu");

    }


}
