using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintGM : MonoBehaviour
{
    public Transform baseDot;
    public KeyCode mouseleft;
    public static string tooltype;
    public static Color currentColor;
    public static int currentOrder;

    bool paper = false;

    void Start()
    {
        paper = false;
    }

    void Update()
    {
        Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

        if (mousePosition.y < 992 && mousePosition.y > 548 && mousePosition.x < 1395 && mousePosition.x > 536)
        {
            paper = true;
        }
        else
        {
            paper = false;
        }


        if (Input.GetKey(mouseleft) && paper)
        {
            
            Instantiate(baseDot, objPosition, baseDot.rotation);
        }
        
    }
}
