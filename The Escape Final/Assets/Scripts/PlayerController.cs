using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody robotRIGBODY;
    private Animator PlayerMov;

    private float jumpP = 10;
   // private float gravityModifier = 2;
    private bool isOnground = true;
    private float horizontalInput;
    private float speed = 5.0f;
    private float Xrange = 5;

    void Start()
    {
        //gets the main components of rigidbody and animator 
        robotRIGBODY = GetComponent<Rigidbody>();
        PlayerMov = GetComponent<Animator>();

       // gravityModifier = 2;
       // Physics.gravity *= gravityModifier;
 
    }

    // Update is called once per frame
    void Update()
    {
        //sets "Space" as the default key for jumping
        if (Input.GetKeyDown(KeyCode.Space) && isOnground)
        {
            //Sets what the space bar action will be 
            robotRIGBODY.AddForce(Vector3.up * jumpP, ForceMode.Impulse);
            //Makes the game know that when space is pressed gravity is 0
            isOnground = false;
            //Sets a trigger for the animator to know when spacebar is pressed down to do the jump animation
            PlayerMov.SetTrigger("Jump_trig");
        }
        //Sets inbound barriers so the player cant run off the map
        if (transform.position.x < -Xrange)
        {
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > Xrange)
        {
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        }


        //sets what position the player will be placed
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.y < -1f)
        {
        //If the player goes below 1 (falls in water)than the game will end
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        //Tells the game that gravity exists
        isOnground = true;
    }
}
