using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public float thrust;
	public float friction;
    public Rigidbody2D rb;
	public float jumpVelocity;
	public bool canJump;
	public float maxSpeed;
	
	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
	
	void Update()
	{
		if(canJump == true)
		{
			if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)
				|| Input.GetButtonDown("Jump"))
			{
				GetComponent<Rigidbody2D>().velocity += Vector2.up * jumpVelocity;
				canJump = false;
			}
		}
	}
/*	
	void falsify
	{
		canJump = false;
	}
*/	
	void OnCollisionStay2D (Collision2D collision) 
	{
       if (collision.gameObject.tag == "Ground") 
		{
             canJump = true;
        }
/*		else
		{
			 Invoke(falsify, .25);
		}
*/	}

    void FixedUpdate()
    {
		//Movement
		if (Input.GetAxis("Horizontal") != 0)
		{
			rb.AddForce(Vector2.right * thrust * Input.GetAxis("Horizontal"), ForceMode2D.Impulse);
		}
/*		if (Input.GetAxis("Vertical") != 0)
		{
			rb.AddForce(Vector2.up * thrust * Input.GetAxis("Vertical"), ForceMode2D.Impulse);
		}
*/
		
		//Adding friction
		if (Input.GetAxis("Horizontal") == 0 && rb.velocity.x > 0 && canJump) //testing &canJump
		{
			rb.AddForce(Vector2.left * friction);
		}
		if (Input.GetAxis("Horizontal") == 0 && rb.velocity.x < 0 && canJump)
		{
			rb.AddForce(Vector2.right * friction);
		}
		
		
		//Limiting the speed of player
        if (rb.velocity.x > maxSpeed) {
            rb.velocity = new Vector2 (maxSpeed, rb.velocity.y);
        }

        if (rb.velocity.x < -maxSpeed) {
            rb.velocity = new Vector2 (-maxSpeed, rb.velocity.y);
        }
		 
		
		//Eliminating creep		//depends on bounciness probably...
		//if (rb.velocity.x)
	}
}