using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = paintGM.currentColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if (paintGM.tooltype == "eraser")
            Destroy(gameObject);
    }
}
