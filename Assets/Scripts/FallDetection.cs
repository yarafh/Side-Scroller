using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetection : MonoBehaviour
{
    [SerializeField] Vector3 Checkpoint;

    void FixedUpdate()
    {
        if(transform.position.y<-10)
        {
            transform.position=Checkpoint;
        }
    }
}
