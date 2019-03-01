using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JawMover : MonoBehaviour
{
  public float jawThrust;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * Random.Range(-30,30));
    }

    void FixedUpdate()
    {
        
    }
}
