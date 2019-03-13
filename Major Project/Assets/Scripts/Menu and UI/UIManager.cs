using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    Scene CurrentScene;
    public Canvas MainMenuCanves;


    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        CurrentScene = SceneManager.GetActiveScene();
    }

    public void EnableCanves()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CurrentScene = SceneManager.GetActiveScene();

        if(CurrentScene.name == "MainMenu")
        {

        }
    }
}
