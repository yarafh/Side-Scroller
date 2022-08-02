using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FLlvl1 : MonoBehaviour
{
    [SerializeField] private string level1, level2;
    [SerializeField] private KeyCode one, two;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("You WIN! (Pick your next level.. Press Tab for Level1 and Down for Level2 :)");   
        if(Input.GetKeyDown(one))
            SceneManager.LoadScene(level1);
        if(Input.GetKeyDown(two))
            SceneManager.LoadScene(level2);
    }
}
