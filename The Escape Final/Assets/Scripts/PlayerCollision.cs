using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    void Start()
    {

    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        // This states that when the player collides with an object that ahs the obstacle tag, the game is over
       if (collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();
            SceneManager.LoadScene("GameOver");
        }
    }
}
