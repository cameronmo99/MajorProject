using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAIScript : MonoBehaviour
{
    public float Speed;
    public Transform Waypoint;
    public Rigidbody AIGameObject;
    public float Distance;

    public RaycastHit Forward;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the Enemy look at the Waypoint
        transform.LookAt(Waypoint);

        //If the Distance it more than 0 the Enemy will move towards the Player
        if (Vector3.Distance(transform.position, Waypoint.position) >= Distance)
        {
            transform.position += transform.forward * Speed * Time.deltaTime;
        }
    }

    public void GetNewWaypoint()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 10) && )  //&& (RaycastHit..gameObject.tag =="Waypoint"))     // gameObject.tag == "Waypoint"))
        //if (Physics.Raycast(transform.position, fwd, out hit, Reach) && hit.transform.tag == "Dynamic")
        {
            //if (Forward.transform.tag == "Waypoint")
            //{
                print("There is something in front of the object!");
            //}
        }

        Debug.DrawRay(transform.position, fwd, Color.green);
    }


}
