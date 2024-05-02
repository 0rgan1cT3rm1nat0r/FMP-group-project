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

        if (mousePosition.y < 144 && mousePosition.y > 71.50 && mousePosition.x < 1485 && mousePosition.x > 1400 && Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(penTexture, new Vector2(14, 154), CursorMode.Auto);
            Debug.Log("Pen");
        }

        if (mousePosition.y < 144 && mousePosition.y > 71.50 && mousePosition.x < 1725 && mousePosition.x > 1650 && Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(eraserTexture, new Vector2(14, 154), CursorMode.Auto);
            Debug.Log("Eraser");
        }

    }
}
