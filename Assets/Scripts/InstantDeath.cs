using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantDeath : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Hazard"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
