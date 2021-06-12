using UnityEngine;

public class Building : MonoBehaviour
{
	// Configuration Parameters
	[Header("Build Cost")] 
	[SerializeField] private int woodResourceCost;
	[SerializeField] private int stoneResourceCost;
	
	// Internal Variables
	private ResourceManager resourceManager;
	private ResourceSet buildCost;
	
	// Internal Methods
	private void Start() {
		FindResourceManager();
		GenerateBuildingResourceSet();
	}

	private void FindResourceManager() {
		resourceManager = GameObject.FindObjectOfType<ResourceManager>();
		if (!resourceManager) {
			Debug.LogError("No ResourceManager Found. Disabling Building.");
			gameObject.SetActive(false);
		}
	}

	private void GenerateBuildingResourceSet() {
		buildCost = new ResourceSet(woodResourceCost, stoneResourceCost);
	}

	// Public Methods
	public void createBuilding() {
		bool canAffordBuilding = resourceManager.CheckBuildingAffordability(buildCost);
		if (canAffordBuilding) {
			// Place building
		} else {
			// Not enough resources
		}
	}
}