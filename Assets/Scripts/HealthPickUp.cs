using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    private PlayerHealth playerHealthScript;
    public AudioSource healSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerHealthScript=other.gameObject.GetComponent<PlayerHealth>();
            healSound.Play();
            playerHealthScript.health++;
            Destroy(gameObject);
        }
    }
}
