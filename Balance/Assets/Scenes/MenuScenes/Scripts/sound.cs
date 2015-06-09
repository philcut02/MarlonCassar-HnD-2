using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {

	//Add a reference to the audio clip
	public AudioClip startSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
		
		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource>().PlayOneShot (startSound);
			
			
		}	
	}
}
