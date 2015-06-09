using UnityEngine;
using System.Collections;

public class arcadeMode : MonoBehaviour {

	//Add a reference to the audio clip
	public AudioClip episodeSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource>().PlayOneShot (episodeSound);
			
			
		}	
	}

	void OnMouseDown()
	{
		
		Application.LoadLevel (2);
	}

}
