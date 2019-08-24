using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //Reference to RigidBody
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 750f;
    public float jumpForce = 5000f;


	// Use this for initialization
	void Start () {
	
	}
	


	// Update is called once per frame
    // FixedUpadate as messing with physics
	void FixedUpdate ()
    {
        //Add a Forward Force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);	//Add a force of 2000 on z axis

        //Add Right Strafe
        if (Input.GetKey("d") )
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //Add Left Strafe
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }


        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }



    }
}
