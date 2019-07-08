using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void showCredit()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void showMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void showDialog()
    {
        SceneManager.LoadScene("Dialogue");
    }

    public void showBattle()
    {
        SceneManager.LoadScene("First");
    }

    public void showScene()
    {
        SceneManager.LoadScene("ShipScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
