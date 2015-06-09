using UnityEngine;
using System.Collections;

public class pcontroller : MonoBehaviour {
	
	public int powerUpSpeed;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//rotate in Z multiplied by speed multiplied
		//by how long it takes to draw a frame
		transform.Rotate (new Vector3 (0, 0, 1) * powerUpSpeed * Time.deltaTime);
		
		//move the asteroid DOWN towards the player in GLOBAL coordinates.  Asteroid stops at the bottom of the screen
		if (transform.position.z > -4) {
			transform.Translate (new Vector3 (-1,0, 0) * powerUpSpeed * Time.deltaTime, Space.World);
		} else { 
			//these things happen if asteroid has hit the bottom
			Destroy (this.gameObject);
			
		}
		
		
	}
}
