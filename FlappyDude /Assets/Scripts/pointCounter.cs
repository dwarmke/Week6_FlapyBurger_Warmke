using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pointCounter : MonoBehaviour
{
   public GameObject deathScrean;
    public int points;

    public Text pointKeeper;
   
   public AudioSource chompSound;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Death")
        {
        deathScrean.SetActive(true);
        //camera.fieldOfView += scroll*zoomSpeed;
        Destroy(gameObject);
        }

        points = (points + 1);
        print(points);
        //pointKeeper.text = points.ToString();
        chompSound.Play(0);
    }

}
