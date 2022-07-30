using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;

    private Rigidbody rb;
    private bool canJump=true;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        bool grounded=Physics.Linecast(transform.position, groundCheck.position, groundLayer);
        Debug.DrawLine(transform.position, groundCheck.position, Color.red);
        
        if(grounded==true)
            canJump=true;
        else
            canJump=false;
        Jump();
    }

    private void Jump()
    {
        if(Input.GetButtonDown("Jump") && canJump==true)
        {
            canJump=false;
            rb.AddForce(Vector3.up*jumpForce);
        }
    }
}
