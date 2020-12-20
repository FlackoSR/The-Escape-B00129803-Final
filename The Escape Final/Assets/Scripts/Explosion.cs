using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{


    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        //does something only when player tag is selected 
        if (other.CompareTag("Player"))
        {
           Pickup(other);
        }
    }
    void Pickup(Collider Player)
    {
     

        //Destroys the effect
        Destroy(gameObject);
    }
}
