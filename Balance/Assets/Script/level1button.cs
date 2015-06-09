using UnityEngine;
using System.Collections;

public class level1button : MonoBehaviour
{
	//Add a reference to the audio clip
	public AudioClip clickSound;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource>().PlayOneShot (clickSound);
			
			
		}	
	
	}

	void OnMouseDown ()
	{
		
		Application.LoadLevel (3);
	}


}
