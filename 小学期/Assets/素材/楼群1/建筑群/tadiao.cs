using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tadiao : MonoBehaviour
{
    
    //public int count = 0;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*0.1f, Space.World);
        if (transform.rotation.y > 90)
        {
            transform.Rotate(0, 0, 0);
        }
        return;
        

    }
}