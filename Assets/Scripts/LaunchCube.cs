using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*500);
    }
}
