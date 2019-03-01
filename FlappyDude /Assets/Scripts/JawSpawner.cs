using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JawSpawner : MonoBehaviour
{
    public float spawnSpot = 20;
    public GameObject jaw;

    Transform lastSpawnerJaw;

    public float jawMaker = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lastSpawnerJaw == null)
        {
           lastSpawnerJaw = Instantiate(jaw, new Vector3(spawnSpot, Random.Range(-4,4) ,0), Quaternion.identity).transform;
           
        }
        else
        {
            if(lastSpawnerJaw.transform.position.x < jawMaker)
            {
                lastSpawnerJaw = Instantiate(jaw, new Vector3(spawnSpot, Random.Range(-4,4) ,0), Quaternion.identity).transform;
            }
        }
    }
}
