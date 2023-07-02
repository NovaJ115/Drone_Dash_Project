using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public bool cloud;
    public bool tree;
    public float cloudSpeed;
    public float treeSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cloud == true)
        {
            gameObject.transform.Translate(cloudSpeed, 0, 0);
        }
        
        if(tree == true)
        {
            gameObject.transform.Translate(treeSpeed, 0, 0);
        }

    }
}
