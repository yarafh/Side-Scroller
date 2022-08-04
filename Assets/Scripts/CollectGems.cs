using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGems : MonoBehaviour
{
    public int Gems=0;
    public AudioSource gemSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Gem"))
        {
            Gems++;
            gemSound.Play();
            Destroy(other.gameObject);
            Debug.Log("Gems Collected: "+Gems);
        }
    }
}
