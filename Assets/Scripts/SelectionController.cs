using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionController : MonoBehaviour
{

    RaycastHit hit;
    private readonly int buildLayerMask = 1 << 7;
    private readonly int resourceLayerMask = 1 << 8;
    private int ObjectLayerMask;


    Vector2 mousePos;

    void Start()
    {
        ObjectLayerMask = buildLayerMask | resourceLayerMask;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(mousePos);

            Debug.Log("TODO");

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, ObjectLayerMask))
            {
                Debug.Log("TODO");
                //todo call the interface function to open up infos about the object
            }
        }
    }
}
