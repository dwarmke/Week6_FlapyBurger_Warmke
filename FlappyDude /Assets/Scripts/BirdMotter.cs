using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BirdMotter : MonoBehaviour
{
    public Rigidbody2D burgerBody;
    public float jumpSpeed = 5;

    public GameObject deathScrean;

    public AudioSource flapSound;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("space");
            burgerBody.velocity = new Vector2(burgerBody.velocity.x, jumpSpeed);
            flapSound.Play(0);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("smack");
        deathScrean.SetActive(true);
        //camera.fieldOfView += scroll*zoomSpeed;
        Destroy(gameObject);
    }

}
