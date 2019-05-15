using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public GameObject GameManager;

    public void BackToMenu()
    {
        GameManager = GameObject.Find("GameManager");
        SceneManager.LoadScene("MainMenu");
        Destroy(GameManager);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
