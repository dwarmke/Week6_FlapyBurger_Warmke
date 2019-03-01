using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jawMottor : MonoBehaviour
{
    public float jawSpeed = 5;
    public float deSpawn = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * jawSpeed * Time.deltaTime);

        if(transform.position.x < deSpawn)
        {
            Destroy(gameObject); 
        }
    }
}
