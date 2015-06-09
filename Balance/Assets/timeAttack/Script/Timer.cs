using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

	//Add a reference to the audio clip
	public AudioClip boxSound;


	//variable for the GUI skin
	public GUISkin stylesheet;

	//Declare a variable for the current time
	float currentTime;
	
	
	//Declare a variable for the start time
	float startTime;

	

	
	
	// Use this for initialization
	void Start ()
	{
		
		
		//save the time when I pressed play
		startTime = Time.time;
		

		
	}

	//create OnGui method
	string minutes;
	string seconds;

	//create OnGui method
	void OnGUI ()
	{
		
		minutes = Mathf.Floor (currentTime / 60).ToString ("00");
		seconds = Mathf.Floor (currentTime % 60).ToString ("00");
		
		
		
		GUI.skin = stylesheet;
		
		GUI.Label (new Rect (10f, 10f, 150, 30), "Timer : ");
		GUI.Label (new Rect (80f, 10f, 150, 30), minutes + " : " + seconds);
		

		
		if (GUI.Button (new Rect (Screen.width / 2 - 100f, Screen.height / 50f, 200f, 50f), "Main Menu")) {
			

			
			Application.LoadLevel (0);
		}

		if (GUI.Button (new Rect (Screen.width - 150f, Screen.height / 50f, 55f, 50f), "Pause")) {
			
			
			
			Time.timeScale = 0f;
		}

		if (GUI.Button (new Rect (Screen.width - 95f, Screen.height / 50f, 55f, 50f), "Play")) {
			
			
			
			Time.timeScale = 1f;
		}

		if (GUI.Button (new Rect (Screen.width - 250f, Screen.height / 50f, 100f, 50f), "Restart")) {
			
			
			
			Application.LoadLevel(9);
		}

		
	}

	void Update ()
	{
		
		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource> ().PlayOneShot (boxSound);
			
			
		}	
		
		
		//Calculate how long I have been playing for in milliseconds
		currentTime = Time.time - startTime;
		
		//After 30 seconds go to level 2
		if (currentTime > 30 && Application.loadedLevelName == "TimeAttack") {
			
			Application.LoadLevel ("GameOver");
			
		}
		
			
		
		//go back to the main menu if esc button is pressed
		if (Input.GetKeyDown (KeyCode.Escape)) {
			

			Application.LoadLevel (0);
		}




	}




}