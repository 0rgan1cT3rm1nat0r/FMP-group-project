using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{

    public GameObject cube;

    public void Spawn(Vector2 position)
    {
        Instantiate(cube).transform.position = position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

            Vector2 adjustZ = new Vector2(worldPoint.x, worldPoint.y);

            Spawn(adjustZ);
        }
    }
}