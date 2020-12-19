using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerObj : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
        void Pickup()
        {
            Debug.Log("Powered Uped");
        }

    }
}
