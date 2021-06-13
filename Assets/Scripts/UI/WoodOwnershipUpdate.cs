using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodOwnershipUpdate : MonoBehaviour
{
    public GameObject woodResource;
    private int woodOwned;
    public ResourceManager resManager;

    void Update()
    {
        GameObject text = woodResource.transform.Find("WoodCounter").gameObject;
        woodOwned = resManager.GetResourceCount(0);
        text.GetComponent<Text>().text = woodOwned.ToString();
    }
}
