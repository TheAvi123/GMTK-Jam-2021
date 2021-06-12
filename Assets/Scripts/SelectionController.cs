using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionController : MonoBehaviour
{

    RaycastHit hit;
    private readonly int buildLayerMask = 1 << 7;
    private readonly int resourceLayerMask = 1 << 8;
    private int ObjectLayerMask;
    private InputManager inputManager;
    // Start is called before the first frame update
    void Start()
    {
        ObjectLayerMask = buildLayerMask | resourceLayerMask;
        inputManager = InputManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {

        if (inputManager.)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, ObjectLayerMask))
            {
                Debug.Log("TODO");
                //todo call the interface function to open up infos about the object
            }
        }
    }
}
