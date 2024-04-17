using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintGM : MonoBehaviour
{
    public Transform baseDot;
    public KeyCode mouseleft;
    public static string tooltype;

    void Start()
    {

    }

    void Update()
    {
        Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

        if (Input.GetKey (mouseleft))
        {
            Instantiate (baseDot, objPosition, baseDot.rotation);


        }
    }
}
