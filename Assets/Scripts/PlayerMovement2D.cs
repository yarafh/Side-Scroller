using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
   
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal")*speed,0);
        rb.velocity = new Vector2(movement.x,rb.velocity.y);
    }
}
