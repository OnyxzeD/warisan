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

    public void showApproachBoss()
    {
        SceneManager.LoadScene("Approaching Boss");
    }

    public void showMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void showApproachIsland()
    {
        SceneManager.LoadScene("ApproachingIsland");
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

    public void showMap()
    {
        SceneManager.LoadScene("Map");
    }

    public void showStage1()
    {
        SceneManager.LoadScene("Stage1Level1");
    }

    public void showStage2()
    {
        SceneManager.LoadScene("Stage1Level2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
