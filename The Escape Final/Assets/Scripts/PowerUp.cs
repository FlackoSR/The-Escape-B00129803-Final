using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private float Shrinkmultiplier = 0.5f;
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

        //applies effect to the player
        Player.transform.localScale *= Shrinkmultiplier;

        //disable graphics
        //gets rid of the collider so it cant be used again wile activated
        GetComponent<Collider>().enabled = false;
        //Wait time till you can use the powerup again
        yield return new WaitForSeconds(waitTime);
        //After the wait time specified this will cancel out the powerUp and restore the player
        Player.transform.localScale /= Shrinkmultiplier;
        //Destroys the effect
        Destroy(gameObject);


    }
     
}
