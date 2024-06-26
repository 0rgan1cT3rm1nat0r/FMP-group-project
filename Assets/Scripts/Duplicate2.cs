using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate2 : MonoBehaviour
{
    private RectTransform rectTransform;
    public GameObject sticker2Prefab;

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

        if (mousePosition.x > 1800 && mousePosition.x < 1900 && mousePosition.y > 600 && mousePosition.y < 800 && Input.GetMouseButtonDown(0))
        {
            //Instantiate(sticker2Prefab, new Vector2(100, 100), Quaternion.identity);

            GameObject sticker2 = Instantiate(sticker2Prefab, new Vector2(100, 100), Quaternion.identity) as GameObject;
            sticker2.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
    }
}
