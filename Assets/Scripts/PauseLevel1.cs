using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseLevel1 : MonoBehaviour
{
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    void TogglePauseMenu()
    {
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(!pauseMenuUI.activeSelf);

            if (pauseMenuUI.activeSelf)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene("PauseLevel1");
    }

public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }


}