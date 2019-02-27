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

    public GameObject WaypointForward;
    public GameObject WaypointLeft;
    public GameObject WaypointRight;
    public GameObject WaypointBackwards;

    public List<GameObject> WaypointsList;



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
                WaypointsList.Add(HitForward.transform.gameObject);
                Debug.Log("ForwardHit");
                //WaypointForward = 
            }

        }

        if (Physics.Raycast(transform.position, Vector3.left, out HitLeft, RaycastDistance))
        {

            if (HitLeft.transform.tag == "Waypoint")
            {
                WaypointsList.Add(HitLeft.transform.gameObject);
                Debug.Log("LeftHit");
            }

        }

        if (Physics.Raycast(transform.position, Vector3.right, out HitRight, RaycastDistance))
        {

            if (HitRight.transform.tag == "Waypoint")
            {
                WaypointsList.Add(HitRight.transform.gameObject);
                Debug.Log("RightHit");
            }

        }

        if (Physics.Raycast(transform.position, Vector3.back, out HitBackwards, RaycastDistance))
        {

            if (HitBackwards.transform.tag == "Waypoint")
            {
                WaypointsList.Add(HitBackwards.transform.gameObject);
                Debug.Log("BackwardsHit");
            }
        }
        Debug.Log(WaypointsList);
        Debug.DrawRay(transform.position, Vector3.forward, Color.green);
        Debug.DrawRay(transform.position, Vector3.left, Color.blue);
        Debug.DrawRay(transform.position, Vector3.right, Color.blue);
        Debug.DrawRay(transform.position, Vector3.back, Color.black);
    }

    public void ClearWaypointsList()
    {
        WaypointsList.Clear();
    }

    public void ChooseWaypoint()
    {

    }
}



