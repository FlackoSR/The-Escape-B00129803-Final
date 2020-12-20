
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Makes a transform variable for the player
    public Transform player;
    //sets score text
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        //sets the score imrement from the Z position of the background
        scoreText.text = player.position.z.ToString("0");
    }
}
