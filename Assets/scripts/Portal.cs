using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Portal : MonoBehaviour
{

	public Rigidbody2D rb;
	public float toXPos;		// 437
	public float toYPos;		// -13
	
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D CircleCollider2D)
	{
		rb.transform.position = new Vector3(toXPos, toYPos, rb.transform.position.z);
	}
}
