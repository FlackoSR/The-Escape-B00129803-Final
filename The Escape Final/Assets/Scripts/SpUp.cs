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
        //applies effect to the player
        Player.transform.localScale *= Growthmultiplier;

        //disable graphics

        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(waitTime);
        Player.transform.localScale /= Growthmultiplier;
        //Destroys the effect
        Destroy(gameObject);


    }
}
