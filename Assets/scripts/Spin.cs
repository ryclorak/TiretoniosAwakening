using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
	[SerializeField]
	Rigidbody2D rb;
	
	public float rotation;
	public float spinFactor;

    void Start()
    {
		
    }

    void Update()
    {
        rotation += Input.GetAxis("Horizontal");
		transform.eulerAngles = new Vector3(0, 0, rotation) * -spinFactor;
    }
}
