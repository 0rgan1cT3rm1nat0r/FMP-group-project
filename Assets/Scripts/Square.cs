using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using Unity.VisualScripting;
using UnityEngine;

public class Square : MonoBehaviour, ICustomDrag
{
    private RectTransform rectTransform;
    public GameObject stickerPrefab;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnCurrentDrag()
    {
        rectTransform.position = Input.mousePosition;
    }

    private void Update()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (mousePosition.x > 1700 && mousePosition.x < 1800 && mousePosition.y > 900 && mousePosition.y < 1000 && Input.GetMouseButtonDown(0))
        {
            Instantiate(stickerPrefab, new Vector2(100, 100), Quaternion.identity);
        }
    }
}

