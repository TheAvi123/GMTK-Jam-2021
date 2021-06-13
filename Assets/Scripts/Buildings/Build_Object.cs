using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_Object : MonoBehaviour
{
    List<GameObject> allBuildings = new List<GameObject>();
    public GameObject[] blueprintPrefabs = default;
    public int[] currentResources = default;

    public void SpawnObjectBlueprint(int index)
    {
        GameObject clone = Instantiate(blueprintPrefabs[index]);
    }
}
