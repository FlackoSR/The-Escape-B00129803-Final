using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeS : MonoBehaviour
{
   //When an object is hit, it will bring us to this scene where you get the option to restart the game
    public void Restart() {
        SceneManager.LoadScene("The Escape");
    }
}
