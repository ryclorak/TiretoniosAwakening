using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class DropOut : MonoBehaviour
{
	
	void Start()
	{
		
	}
		
	private void OnTriggerExit2D(Collider2D other)
	{
		SceneManager.LoadScene("SampleScene");
	}
}