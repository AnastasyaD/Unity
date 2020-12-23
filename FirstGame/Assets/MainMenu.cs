using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject options;

    public void ShowOptions()
    {
        mainMenu.SetActive(false);
        options.SetActive(true);
    }

    public void ShowMenu()
    {
        mainMenu.SetActive(true);
        options.SetActive(false);
    }

    public void StartGame()
    {
        Application.LoadLevel("1");
    }

    public void Exit()
    {
        Application.Quit();
    }



}
