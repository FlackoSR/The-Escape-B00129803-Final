using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float Speedmultiplier = 1.5f;
    public GameObject pickupEffect;

    void Start()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }
    void Pickup(Collider Player)
    {
        //spawns the effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        //applies effect to the player
     
        //Destroys the effect
        Destroy(gameObject);


    }
     
}
