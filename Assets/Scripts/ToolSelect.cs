using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolselect : MonoBehaviour
{
    [SerializeField] private Texture2D penTexture;
    [SerializeField] private Texture2D eraserTexture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (mousePosition.y < 144 && mousePosition.y > 71.50 && mousePosition.x < 1485 && mousePosition.x > 1400)
        {
            Cursor.SetCursor(penTexture, new Vector2(92, 37), CursorMode.Auto);
            Debug.Log("Pen");
        }

        if (mousePosition.y < 144 && mousePosition.y > 71.50 && mousePosition.x < 1725 && mousePosition.x > 1650)
        {
            Cursor.SetCursor(eraserTexture, new Vector2(92, 37), CursorMode.Auto);
            Debug.Log("Eraser");
        }

    }
}
