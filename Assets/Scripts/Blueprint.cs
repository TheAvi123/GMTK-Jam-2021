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
    public Material okMaterial;
    public Material noMoneyMaterial;
    public Material conflictMaterial;
    public float yOffset;
    public bool canBuild;
    public bool canAfford;
    private GameObject resourceManager = GameObject.Find("ResourceManger");
    private int cost; 

    private void Start()
    {
        //canAfford = resourceManager.canAfford(cost);
        

    }

    void Update()
    {

        if (canBuild)
        {
            if (canAfford)
            {
                gameObject.GetComponent<MeshRenderer>().material = okMaterial;
            }
            else
            {
                gameObject.GetComponent<MeshRenderer>().material = noMoneyMaterial;
            }
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = conflictMaterial;
        }
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            Vector3 newPosition = hit.point;
            newPosition.y += yOffset;
            transform.position = newPosition;
        }

        if (Input.GetMouseButtonDown(0))
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
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }
}
