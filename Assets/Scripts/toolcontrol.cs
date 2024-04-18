using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolcontrol : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.name == "icon eraser")
        {
            paintGM.tooltype = "eraser";
            //Debug.Log("erase selected");
        }

        if (gameObject.name == "icon pencil")
        {
            paintGM.tooltype = "pencil";
            //Debug.Log("pencil selected");
        }
    }
}
