using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    Scene CurrentScene;
    public Canvas MainMenuCanves;
    public Canvas SinglePlayerCanvas;
    public Canvas VSCanvas;
    public Canvas OptionsCanvas;

    public bool DisableMainCanvas;

    public float RowsWanted;
    public float ColumnsWanted;

    public Text RowSliderAmount;
    public Text ColumnSliderAmount;
    public Slider RowSlider;
    public Slider ColumnSlider;

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

        if (CurrentScene.name == "MainMenu")
        {
            if (DisableMainCanvas == true)
            {
                MainMenuCanves.gameObject.SetActive(true);
            }
        }

        RowsWanted = RowSlider.value;
        ColumnsWanted = ColumnSlider.value;
        RowSliderAmount.text = RowsWanted.ToString();
        ColumnSliderAmount.text = ColumnsWanted.ToString();

    }





















    public void SinglePlayerButton()
    {
        DisableMainCanvas = true;
        MainMenuCanves.gameObject.SetActive(false);
        SinglePlayerCanvas.gameObject.SetActive(true);
        DisableMainCanvas = false;
    }

    public void BackButton()
    {
        DisableMainCanvas = false;
        MainMenuCanves.gameObject.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void PlaySinglePlayerGame()
    {
        SceneManager.LoadScene("SinglePlayer");
    }

}
