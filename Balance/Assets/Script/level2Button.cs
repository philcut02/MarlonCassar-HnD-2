using UnityEngine;
using System.Collections;

public class level2Button : MonoBehaviour
{
	//Add a reference to the audio clip
	public AudioClip level2Sound;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource>().PlayOneShot (level2Sound);
			
			
		}	
	
	}

	void OnMouseDown ()
	{
		
		Application.LoadLevel (4);
	}

}
