using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallMultiplier : MonoBehaviour
{
    public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;
	
	Rigidbody2D rb;
	
	void Awake()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

    void Update()
    {
    if (rb.velocity.y < 0)
		{
		rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime; 
		}		 
    }
}