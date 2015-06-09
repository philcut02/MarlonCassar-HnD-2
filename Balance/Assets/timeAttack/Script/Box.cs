using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour
{
	
	//Add a reference to the audio clip
	public AudioClip boxSound;
	
	Vector3 dist;
	float posX;
	float posY;
	
	
	

	
	
	
	
	// Use this for initialization
	void Start ()
	{
		
		

		
		
	}
	


	
	void Update ()
	{
		
		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource> ().PlayOneShot (boxSound);
			
			
		}	
		
		

		
		
		//go back to the main menu if esc button is pressed
		if (Input.GetKeyDown (KeyCode.Escape)) {
			
			
			Application.LoadLevel (0);
		}
		
		
		
		
	}
	
	void OnMouseDown ()
	{
		dist = Camera.main.WorldToScreenPoint (transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;
		
	}
	
	void OnMouseDrag ()
	{
		Vector3 curPos = 
			new Vector3 (Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);  
		
		Vector3 worldPos = Camera.main.ScreenToWorldPoint (curPos);
		transform.position = worldPos;
	}
	
	
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "water")
		{
			Application.LoadLevel(10);
			//If cube hits water, Game Over
			
		}
	}
	
	
}