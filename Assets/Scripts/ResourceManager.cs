using System;
using System.Security.Cryptography;

using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    // Configuration Parameters
    [Header("Initial Resource Counts")] 
    [SerializeField] private int initialWoodCount = 100;
    [SerializeField] private int initialStoneCount = 100;
    
    // State Variables
    [Header("Resource Stockpile")] 
    private int numberOfResources;
    private int[] resourceStockpiles;

    //Internal Methods
    void Start() {
        InitializeResourceStockpiles();
    }
    
    private void InitializeResourceStockpiles() {
        numberOfResources = Enum.GetNames(typeof(Resource)).Length;
        if (numberOfResources == 0) {
            Debug.LogError("No Resources Found. Shutting Down ResourceManager.");
            gameObject.SetActive(false);
        }
        resourceStockpiles = new int[numberOfResources];
        // Set initial amounts
        resourceStockpiles[0] = initialWoodCount;
        resourceStockpiles[1] = initialStoneCount;
    }

    // Public Methods
    public void AddResource(Resource resource, int amount) {
        resourceStockpiles[(int) resource] += amount;
    }
    
    public void RemoveResource(Resource resource, int amount) {
        resourceStockpiles[(int) resource] -= amount;
    }

    public int GetResourceCount(Resource resource) {
        return resourceStockpiles[(int) resource];
    }
    
    public bool CheckResourceAvailability(Resource resource, int amount) {
        return resourceStockpiles[(int) resource] >= amount;
    }
    
    public bool CheckBuildingAffordability(ResourceSet buildCost) {
        if (!CheckResourceAvailability(Resource.Wood, buildCost.wood) ||
            !CheckResourceAvailability(Resource.Stone, buildCost.stone)) {
            return false;
        }
        return true;
    }
}
