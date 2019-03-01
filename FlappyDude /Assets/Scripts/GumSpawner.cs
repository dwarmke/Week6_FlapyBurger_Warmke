using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumSpawner : MonoBehaviour
{
    public float spawnSpot = 20;
    public GameObject gums;

    Transform lastSpawnerGum;

    public float gumMaker = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lastSpawnerGum == null)
        {
           lastSpawnerGum = Instantiate(gums, new Vector3(spawnSpot, Random.Range(-4,4) ,0), Quaternion.identity).transform;
           
        }
        else
        {
            if(lastSpawnerGum.transform.position.x < gumMaker)
            {
                lastSpawnerGum = Instantiate(gums, new Vector3(spawnSpot, Random.Range(-4,4) ,0), Quaternion.identity).transform;
            }
        }
    }
}
