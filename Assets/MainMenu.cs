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

    public void QuitGame()
    {
        Application.Quit();
    }
}
