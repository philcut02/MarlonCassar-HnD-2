using UnityEngine;
using System.Collections;

public class dragBox : MonoBehaviour {
	
	//Add a reference to the audio clip
	public AudioClip boxSound;
	
	
	
	Vector3 dist;
	float posX;
	float posY;
	
	

	
	void Update ()
	{
		
		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource>().PlayOneShot (boxSound);
			
			
		}	
		
		
			
		
		
	}
	
	
	
	void OnMouseDown(){
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;

		GetComponent<boxController>().enabled = false;
		
	}
	
	void OnMouseDrag(){
		Vector3 curPos = 
			new Vector3(Input.mousePosition.x - posX, 
			            Input.mousePosition.y - posY, dist.z);  
		
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		transform.position = worldPos;
	}

	void OnBecameInvisible()
	{
		//this object became invisible
		//Application.LoadLevel (0);
		//Application.LoadLevel("Levels");
		//Application.LoadLevel(10);
	}

	

	
	
	
	
	
}