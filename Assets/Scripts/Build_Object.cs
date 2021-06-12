using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_Object : MonoBehaviour
{
    public GameObject objectBlueprint;
    private GameObject clone;

    public void SpawnObjectBlueprint()
    {
        GameObject clone = Instantiate(objectBlueprint);
    }
    public void DestroyObjectBlueprint()
    {
        Destroy(clone);
    }
}
