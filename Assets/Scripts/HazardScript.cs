using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardScript : MonoBehaviour
{
    [SerializeField] private GameObject Hazard;
    private void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.CompareTag("Gem"))
        {
            Destroy(other.gameObject);
            Destroy(Hazard);
            Debug.Log("Threat removed");
        }
   }
}
