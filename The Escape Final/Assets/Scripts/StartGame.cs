using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame()
    {
        //Loads StartScene after a button is pressed to the main game scene
        SceneManager.LoadScene("The Escape");
    }
}
