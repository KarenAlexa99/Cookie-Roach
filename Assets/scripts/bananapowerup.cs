using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bananapowerup : MonoBehaviour {

    public float multiplier = 0.8f;
    public float duration = 4f;

    public GameObject pickupEffect;
    

    void Start()
    {

        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            soundmanager.PlaySound("powerupsound");
            StartCoroutine (Pickup (other) );
            
           
        }
    }
    

    IEnumerator Pickup(Collider2D player)
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        Instantiate(pickupEffect, transform.position, transform.rotation);

        player.transform.localScale *= multiplier;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        


        yield return new WaitForSeconds(duration);

        player.transform.localScale /= multiplier;

        Destroy(gameObject);

    }
   
}

