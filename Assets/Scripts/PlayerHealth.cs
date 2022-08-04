using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private Rigidbody rb;
    private PlayerMovement2D playerScript;
    public int health;
    [SerializeField] private Transform spawnPoint;
    private Transform enemy;
    public AudioSource failureSound;
    private void Start()
    {
        rb=GetComponent<Rigidbody>();
        playerScript=GetComponent<PlayerMovement2D>();
    }

    void FixedUpdate()
    {
        Debug.Log("Health: "+health);
        if(health<=0) 
            Die();   
    }

    private void Die()
    {
        failureSound.Play();
        transform.position=spawnPoint.position;
        health=3;
    }

    private void Damage()
    {
        playerScript.enabled=false;
        rb.AddForce(Vector3.up * 250);
        if(transform.position.x < enemy.position.x)
            rb.AddForce(Vector3.right * -500);
        else
            rb.AddForce(Vector3.right * 500);
        
        Invoke("MoveAgain", 1);
    }

    private void MoveAgain()
    {
        playerScript.enabled=true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            health--;
            enemy=collision.gameObject.transform;
            Damage();
        }
    }
}
