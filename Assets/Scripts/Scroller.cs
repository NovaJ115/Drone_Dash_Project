using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public GameObject scrollableObject;
    public float speed;
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
    }

}
