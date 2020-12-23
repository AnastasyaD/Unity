using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pause;
    public static bool GameIsPaused = false;
    [SerializeField] private GameObject finish;
    [SerializeField] private GameObject dead;

       public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else{
                ShowPause();
            }

        }
    }
          
    public void ShowPause()
    {
        Time.timeScale = 0f;
          pause.SetActive(true);
          GameIsPaused = true;
          finish.SetActive(false);
          dead.SetActive(false);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pause.SetActive(false);
        GameIsPaused = false;
        finish.SetActive(false);
        dead.SetActive(false);
    }
    public void StartGame()
    {
        Application.LoadLevel("1");
    }

    public void OpenMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }

}