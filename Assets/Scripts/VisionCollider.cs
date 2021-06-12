using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCollider: MonoBehaviour
{
    private bool viewCollision;
    private GameObject visionCollider;


    private void Start()
    {
        visionCollider = GameObject.Find("VisionCollider");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.IsChildOf(visionCollider.transform))
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.transform.IsChildOf(visionCollider.transform))
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.IsChildOf(visionCollider.transform))
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
