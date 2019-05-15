using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptV2 : MonoBehaviour
{

    public float speed = 10.0f;
    public float Vertical;
    public float Horizontal;
    public float MaximumX = 25f;
    public float MinimumX = -25f;
    public GameObject Goal;
    public GameObject GameManager;
    public UIManager UIManager;
    public bool EscapeMenu = false;
    public GameObject PauseMenu;

    // Use this for initialization
    void Start()
    {
        // turn off the cursor
        Cursor.lockState = CursorLockMode.Locked;
        PauseMenu = GameObject.Find("PauseMenu");
        Goal = GameObject.FindGameObjectWithTag("Goal");
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
        UIManager GameObjectScript = GameManager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis() is used to get the user's input
        // You can furthor set it on Unity. (Edit, Project Settings, Input)
        Vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(Horizontal, 0, Vertical);
        Goal = GameObject.FindGameObjectWithTag("Goal");
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
        UIManager = GameManager.GetComponent<UIManager>();
        //Vertical = Mathf.Clamp(Vertical, MinimumX, MaximumX);

        if (EscapeMenu == false)
        {
            PauseMenu.gameObject.SetActive(false);
        }


        if (EscapeMenu == false)
        {
            PauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (EscapeMenu == true)
        {
            PauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown("escape"))
        {
            EscapeMenu = !EscapeMenu;
        }
    }
    void OnCollisionStay(Collision col)
    {
        if (gameObject.tag== "Goal")
        {
            UIManager.SPWON = true;
        }

        if (gameObject.name == "EasySP")
        {
            UIManager.SPLOST = true;
        }

        if (gameObject.name == "HardSP")
        {
            UIManager.SPLOST = true;
        }


    }
}