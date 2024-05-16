using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetTrigger : MonoBehaviour
{
    public Timer tim;
    public bool FistDetected;
    public bool ScorchedDetected;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fist")
        {
            FistDetected = true;
            Debug.Log("Fist");

        }

        if (collision.gameObject.tag == "ScorchedEarth")
        {
            ScorchedDetected = true;
            Debug.Log("Earth");
        }
    }
    private void Update()
    {
        if (FistDetected == true && ScorchedDetected == true && tim.done)
        {
            SceneManager.LoadScene("CutScene 2", LoadSceneMode.Single);
        }
        else if (FistDetected == false && ScorchedDetected == false && tim.done)
        {
            DOMyShit();
        }
        




    }
    private void DOMyShit()
    {
        SceneManager.LoadScene("Game over");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
