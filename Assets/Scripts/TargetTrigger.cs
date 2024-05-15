using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetTrigger : MonoBehaviour
{

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
        if (FistDetected == true && ScorchedDetected == true)
        {
            SceneManager.LoadScene("CutScene", LoadSceneMode.Single);
        }

                         

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.tag == "Fist" && collision.gameObject.tag == "ScorchedEarth")
        //{
        //    SceneManager.LoadScene("CutScene", LoadSceneMode.Single);
        //}
    }
}
