using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class WinTrigger : MonoBehaviour
{

	public Rigidbody2D rb;
	public float toXPos;		// can implement some place in current scene
	public float toYPos;		
	
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D CircleCollider2D)
	{
		rb.transform.position = new Vector3(toXPos, toYPos, rb.transform.position.z);
	}
}
