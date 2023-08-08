using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public GameObject scrollableObject;
    public float speed;
    private float originalSpeed;
    private float x;
    private float y;
    public bool isDead;

    public DroneCollider droneCollider;

    public void Start()
    {
        scrollableObject.GetComponent<SpriteRenderer>().drawMode = SpriteDrawMode.Tiled;
        x = scrollableObject.GetComponent<SpriteRenderer>().size.x;
        y = scrollableObject.GetComponent<SpriteRenderer>().size.y;

        droneCollider = FindObjectOfType<DroneCollider>();

        originalSpeed = speed;
    }

    public void Update()
    {

        scrollableObject.GetComponent<SpriteRenderer>().size = new Vector2(x,y);
        x += speed * Time.deltaTime;

        if(droneCollider.dead == true)
        {
            isDead = true;
        }

        if(isDead == true)
        {
            speed = 0;
        }
        if(isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                speed += 4;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                speed = originalSpeed;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                speed -= 2;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                speed = originalSpeed;
            }
        }
        


    }

}
