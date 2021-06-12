using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggler : MonoBehaviour
{
    public float maxSize;
    public float minSize;
    public float maxScaleSpeed;
    public float minScaleSpeed;

    private float desiredSize;
    private float desiredSpeed;
    // Start is called before the first frame update
    void Start()
    {
        GenerateNewSize();
    }

    // Update is called once per frame
    void Update()
    {
        if (desiredSize < transform.localScale.x)
        {
            transform.localScale = new Vector3(transform.localScale.x - desiredSpeed * Time.deltaTime, transform.localScale.y - desiredSpeed * Time.deltaTime, transform.localScale.z - desiredSpeed * Time.deltaTime);

            if (transform.localScale.x <= desiredSize)
            {
                GenerateNewSize();
            }
        }
        else if (desiredSize > transform.localScale.x)
        {
            transform.localScale = new Vector3(transform.localScale.x + desiredSpeed * Time.deltaTime, transform.localScale.y + desiredSpeed * Time.deltaTime, transform.localScale.z + desiredSpeed * Time.deltaTime);

            if (transform.localScale.x >= desiredSize)
            {
                GenerateNewSize();
            }
        }
    }

    private void GenerateNewSize()
    {
        desiredSize = Random.Range(minSize, maxSize);
        desiredSpeed = Random.Range(minScaleSpeed, maxScaleSpeed);
    }
}
