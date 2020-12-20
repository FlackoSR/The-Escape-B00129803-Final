using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
 
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
        //outputs the explosion effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        //Destroys the effect
        Destroy(gameObject);
    }
}
