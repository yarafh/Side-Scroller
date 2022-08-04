using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FLlvl1 : MonoBehaviour
{
    [SerializeField] private string level1, level2;
    [SerializeField] private KeyCode one, two;
    public AudioSource victorySound;

    private void OnTriggerEnter(Collider other)
    {
        victorySound.Play();
         Debug.Log("You WIN! (Pick your next level.. Press Tab for Level1 and Down for Level2 :)");
    }

    private void OnTriggerStay(Collider other)
    {   
        if(Input.GetKeyDown(one))
            SceneManager.LoadScene(level1);
        if(Input.GetKeyDown(two))
            SceneManager.LoadScene(level2);
    }
}
