using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject GoalGameObject;
    public GameObject GameManager;
    public UIManager UIManager;

    void Start()
    {
        GoalGameObject = GameObject.FindGameObjectWithTag("Goal");
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
        UIManager = GameManager.GetComponent<UIManager>();
    }
    void OnCollisionStay(Collision col)
    {
        if (gameObject.name == "Player")
        {
            Debug.Log("Why");
            UIManager.SPWON = true;
        }
        if (gameObject.tag == "Player1")
        {
            Debug.Log("please");
        }
        if (gameObject.name == "Player2")
        {
            UIManager.SPWON = true;
        }
    }
}
