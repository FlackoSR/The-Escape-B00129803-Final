using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{

    AudioSource Running;

    // Start is called before the first frame update
    void Start()
    {
        Running = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PlayerFootstepSound()
    {
        //adds sounds to the footsteps
        Running.Play();
    }
}
