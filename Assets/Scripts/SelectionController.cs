using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionController : MonoBehaviour
{

    RaycastHit hit;
    private int buildLayerMask;
    private int resourceLayerMask;
    private int ObjectLayerMask;


    Vector2 mousePos;

    void Start()
    {
    buildLayerMask = LayerMask.NameToLayer("Buildings");
    resourceLayerMask = LayerMask.NameToLayer("Resources");
    }

    // Update is called once per frame
    void Update()
    {
        buildLayerMask = LayerMask.NameToLayer("Buildings");
        resourceLayerMask = LayerMask.NameToLayer("Resources");
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                if (hit.transform.gameObject.layer == buildLayerMask)
                {
                    Debug.Log("TODO");
                    //todo call the interface function to open up infos about the object
                }
                else if (hit.transform.gameObject.layer == resourceLayerMask)
                {
                    Debug.Log("TODO");
                    //todo call the interface function to open up infos about the object
                }
        }
    }
}
