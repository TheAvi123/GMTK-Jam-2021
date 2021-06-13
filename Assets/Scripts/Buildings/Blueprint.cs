using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Blueprint : MonoBehaviour
{

    RaycastHit hit;
    Vector3 movePoint;
    private readonly int layerMask = 1 << 6;
    private readonly int buildLayerMask = 1 << 7;
    private int BuildingColissionLayerMask;
    public GameObject realObject;
    public Material okMaterial;
    public Material noMoneyMaterial;
    public Material conflictMaterial;
    public float yOffset;
    public bool canBuild;
    public bool canAfford;
    public int rotSpeed = 100;

    //----------------------------------------------------
    // Configuration Parameters
    [Header("Build Cost")]
    [SerializeField] private int woodResourceCost;
    [SerializeField] private int stoneResourceCost;

    // Internal Variables
    private ResourceManager resourceManager;
    private ResourceSet buildCost;
    

    private void FindResourceManager()
    {
        resourceManager = GameObject.FindObjectOfType<ResourceManager>();
        if (!resourceManager)
        {
            Debug.LogError("No ResourceManager Found. Disabling Building.");
            gameObject.SetActive(false);
        }
    }

    private void GenerateBuildingResourceSet()
    {
        buildCost = new ResourceSet(woodResourceCost, stoneResourceCost);
    }

    //-------------------------------------------------

    private void Start()
    {
        FindResourceManager();
        GenerateBuildingResourceSet();

        BuildingColissionLayerMask = LayerMask.NameToLayer("Buildings");

        canAfford = resourceManager.CheckBuildingAffordability(buildCost);
        canBuild = true;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer == BuildingColissionLayerMask)
        {
            canBuild = false;
        }
    }
    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.layer == BuildingColissionLayerMask)
        {
            canBuild = false;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.layer == BuildingColissionLayerMask)
        {
            canBuild = true;
        }
    }

    private void MaterialSwitcher(bool build, bool afford)
    {
        if (build)
        {
            if (afford)
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
    }

    private void rotationHandler()
    {
        if (Input.GetKey("e"))
        {
            transform.Rotate(new Vector3(0f, -rotSpeed, 0f) * Time.deltaTime);
        }
        else if (Input.GetKey("q"))
        {
            transform.Rotate(new Vector3(0f, rotSpeed, 0f) * Time.deltaTime);
        }
        else if (Input.GetKeyDown("r"))
        {
            transform.Rotate(new Vector3(0f, 90f, 0f));
        }
    }

    void Update()
    {
        MaterialSwitcher(canBuild, canAfford);
        rotationHandler();
        

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
            else if (canBuild == true && canAfford == true)
            {
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
                {
                    Instantiate(realObject, transform.position, transform.rotation);
                    Destroy(gameObject);
                    resourceManager.RemoveResource(Resource.Wood, buildCost.wood);
                    resourceManager.RemoveResource(Resource.Stone, buildCost.stone);
                }
            }
            else if (canBuild == true && canAfford == false)
            {
                //todo something something, can't afford - Maybe a little popup text.
            }
            else
            {
                Destroy(gameObject);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }
}
