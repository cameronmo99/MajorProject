using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerSinglePlayer : MonoBehaviour
{
    public float PlayerRotationSpeed;
    public float Speed;
    public GameObject Player;
    public Rigidbody PlayerRigidBody;


    void Update()
    {
        //Player Rotation
        Player.transform.Rotate(0, PlayerRotationSpeed * Input.GetAxis("Horizontal"), 0);
    }

    void FixedUpdate()
    {
        //Player Movement
        PlayerRigidBody.AddForce((transform.forward * Speed) * Input.GetAxis("Vertical"));
    }
}
