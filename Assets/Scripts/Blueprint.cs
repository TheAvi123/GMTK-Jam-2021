using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Blueprint : MonoBehaviour
{

    RaycastHit hit;
    Vector3 movePoint;
    private readonly int layerMask = 1 << 6;
    private readonly int UILayerMask = 1 << 5;
    public GameObject realObject;
    public float yOffset;

    void Start()
    {
        
    }
    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            Vector3 newPosition = hit.point;
            newPosition.y += yOffset;
            transform.position = newPosition;
        }

        if (Input.GetMouseButton(0))
        {

            if (EventSystem.current.IsPointerOverGameObject())
            {
                Destroy(gameObject);
            }
            else if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                Instantiate(realObject, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
