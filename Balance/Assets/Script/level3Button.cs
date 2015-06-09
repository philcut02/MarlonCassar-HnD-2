using UnityEngine;
using System.Collections;

public class level3Button : MonoBehaviour
{
	//Add a reference to the audio clip
	public AudioClip level3Sound;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource>().PlayOneShot (level3Sound);
			
			
		}	
	
	}

	void OnMouseDown ()
	{
		
		Application.LoadLevel (5);
	}

}
