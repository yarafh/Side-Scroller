using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetection : MonoBehaviour
{
    Vector3 Checkpoint;
    void Start()
    {
        Checkpoint=new Vector3(470,1,168);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y<-10)
            transform.position=Checkpoint;
    }
}
