using UnityEngine;
using System.Collections;

public class timeAttack : MonoBehaviour
{
	//Add a reference to the audio clip
	public AudioClip level4Sound;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource>().PlayOneShot (level4Sound);
			
			
		}	
	
	}

	void OnMouseDown ()
	{
		
		Application.LoadLevel (6);
	}

}
