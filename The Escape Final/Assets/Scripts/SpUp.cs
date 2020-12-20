using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpUp : MonoBehaviour
{
    private float Growthmultiplier = 1.5f;
    private float waitTime = 5f;
  

    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }
    IEnumerator Pickup(Collider Player)
    {
        //applies the powerup to the player
        Player.transform.localScale *= Growthmultiplier;

        //disable graphics

        GetComponent<Collider>().enabled = false;
        //Sets a waiting time for the powerup to expire
        yield return new WaitForSeconds(waitTime);
        //disables the powerup to the player after the time specified
        Player.transform.localScale /= Growthmultiplier;
        //Destroys the effect
        Destroy(gameObject);


    }
}
