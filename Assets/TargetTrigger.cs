using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fist") //&& collision.gameObject.tag == "ScorchedEarth")
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
