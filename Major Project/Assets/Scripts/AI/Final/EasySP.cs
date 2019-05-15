using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasySP : BaseAIScript
{
    public float EasySpeed = 3;
    public GameObject GameManager;
    public UIManager UIManager;

    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
        UIManager = GameManager.GetComponent<UIManager>();
        Player1Gameobject = GameObject.FindGameObjectWithTag("Player1");
        Player1Transform = Player1Gameobject.transform;
        Player2Gameobject = GameObject.FindGameObjectWithTag("Player2");
        Player2Transform = Player2Gameobject.transform;
        Speed = EasySpeed;
        GetNewWaypoint();
        ChooseWaypoint();
    }


    void Update()
    {
        GoToTarget();
        if (Vector3.Distance(transform.position, Player1Transform.position) < 3)
        {
            SceneManager.LoadScene("SPLOST");
            UIManager.SPLOST = true;
        }
    }
}
