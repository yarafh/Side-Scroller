using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGems : MonoBehaviour
{
    public int Gems=0;
    private void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.CompareTag("Gem"))
        {
            Gems++;
            Destroy(other.gameObject);
            Debug.Log("Gems Collected: "+Gems);
        }
    }
}
