using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAIScript : MonoBehaviour
{
    public float Speed;
    public Transform Waypoint;
    public Rigidbody AIGameObject;
    public float Distance;


    public float RaycastDistance;
    public RaycastHit HitForward;
    public RaycastHit HitLeft;
    public RaycastHit HitRight;
    public RaycastHit HitBackwards;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the Enemy look at the Waypoint
        //transform.LookAt(Waypoint);

        //If the Distance it more than 0 the Enemy will move towards the Player
        if (Vector3.Distance(transform.position, Waypoint.position) >= Distance)
        {
            transform.position += transform.forward * Speed * Time.deltaTime;
        }
    }

    public void GetNewWaypoint()
    {
        //Vector3 fwd = transform.TransformDirection(Vector3.forward);

        // if (Physics.Raycast(transform.position, fwd, 10, out hit))
        if (Physics.Raycast(transform.position, Vector3.forward, out HitForward, RaycastDistance))
        {

            if (HitForward.transform.tag == "Waypoint")
            {
                Debug.Log("ForwardHit");
            }

        }

        if (Physics.Raycast(transform.position, Vector3.left, out HitLeft, RaycastDistance))
        {

            if (HitForward.transform.tag == "Waypoint")
            {
                Debug.Log("LeftHit");
            }

        }

        if (Physics.Raycast(transform.position, Vector3.right, out HitRight, RaycastDistance))
        {

            if (HitForward.transform.tag == "Waypoint")
            {
                Debug.Log("RightHit");
            }

        }

        if (Physics.Raycast(transform.position, Vector3.back, out HitBackwards, RaycastDistance))
        {

            if (HitForward.transform.tag == "Waypoint")
            {
                Debug.Log("BackwardsHit");
            }
        }

        Debug.DrawRay(transform.position, Vector3.forward, Color.green);
        Debug.DrawRay(transform.position, Vector3.left, Color.blue);
        Debug.DrawRay(transform.position, Vector3.right, Color.blue);
        Debug.DrawRay(transform.position, Vector3.back, Color.black);
    }


}
