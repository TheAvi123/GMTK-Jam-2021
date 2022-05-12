using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGen: MonoBehaviour
{
    public GameObject cloud;
    public float width = 10;
    public float height = 10;
    public float cloudSize = 5;
    public float ranfactor;
    // Start is called before the first frame update
    void Start()
    {
        ranfactor = cloudSize / 3;
        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                float ranx = Random.Range(0, ranfactor);
                float rany = Random.Range(0, ranfactor);
                GameObject go = Instantiate(cloud, new Vector3(transform.position.x + ranx + x * cloudSize, transform.position.y, transform.position.z + rany + y * cloudSize), Quaternion.identity);

                float randx = Random.Range(0, 360);
                float randy = Random.Range(0, 360);
                float randz = Random.Range(0, 360);
                go.transform.rotation = Quaternion.Euler(randx, randy, randz);
                go.name = "Cloud_" + x + "_" + y;
                go.transform.SetParent(transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
