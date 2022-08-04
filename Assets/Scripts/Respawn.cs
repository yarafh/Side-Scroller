using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private GameObject DC1;
    [SerializeField] private GameObject DC2;
    [SerializeField] private GameObject DC3;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Respawn"))
            DC1.SetActive(true);   
            DC2.SetActive(true);   
            DC3.SetActive(true);   
    }
}
