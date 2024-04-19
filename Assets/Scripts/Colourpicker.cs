using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colourpicker : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        paintGM.currentColor = GetComponent<SpriteRenderer>().color;
        Debug.Log(paintGM.currentColor);
        //paintGM.currentOrder += 1;
    }
}
