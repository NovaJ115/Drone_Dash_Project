using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    public Transform drone;
    public BoxCollider2D droneHitbox;
    public GameObject droneArt;
    


    public float droneSpeed;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (drone.position.y <= 4.5)
            {
                drone.transform.Translate(0, droneSpeed * Time.deltaTime, 0);
                //Debug.Log("Drone Going Up");
                droneArt.transform.rotation = Quaternion.Euler(0, 0, -7);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (drone.position.y >= -4.25)
            {
                drone.transform.Translate(0, -droneSpeed * Time.deltaTime, 0);
                //Debug.Log("Drone Going Up");
                droneArt.transform.rotation = Quaternion.Euler(0, 0, -7);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (drone.position.x >= -0)
            {
                drone.transform.Translate(-droneSpeed * Time.deltaTime, 0, 0);
                //Debug.Log("Drone Going Up");

                droneArt.transform.rotation = Quaternion.Euler(0, 0, 7);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (drone.position.x <= 15)
            {
                drone.transform.Translate(droneSpeed * Time.deltaTime, 0, 0);
                //Debug.Log("Drone Going Up");
                droneArt.transform.rotation = Quaternion.Euler(0, 0, -15);
            }
        }

        if (!Input.anyKey)
        {
            droneArt.transform.rotation = Quaternion.Euler(0, 0, -7);
        }

        


    }

    

}
