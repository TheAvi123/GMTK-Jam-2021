using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextToCost : MonoBehaviour
{
    public GameObject buybuttons;
    public List<int> buildingPrices = new List<int>();

    void Update()
    {
        int i = 0;
        foreach (Transform child in buybuttons.transform)
        {
            GameObject text = child.Find("BuildingCost").gameObject;
            text.GetComponent<Text>().text = buildingPrices[i].ToString();
            i++;
        }
    }
}
