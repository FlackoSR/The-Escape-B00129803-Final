using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    //sets startspeed
    private float speed = 3;
    //sets MaxSpeed of the player
    private float maxSpeed = 15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //sets when the speed increases and makes it stop when then max speed is reached
        if(speed < maxSpeed)
        {
            speed += 0.08f * Time.deltaTime;
        }
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
