using UnityEngine;
using System.Collections;

public class playScreen : MonoBehaviour {

	
	//variable for the GUI skin
	public GUISkin stylesheet;
	
	
	//variable for score and lives
	//declare the varaible as static variables
	public static int score;

	//Declare a variable for the current time
	float currentTime;
	
	
	//Declare a variable for the start time
	float startTime;

	
	
	
	
	// Use this for initialization
	void Start ()
	{
		
		score = 0;

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

		
		GUI.Label (new Rect (10f, 30f, 150, 30), "Timer : ");
		GUI.Label (new Rect (60f, 30f, 150, 30), minutes + " : " + seconds);

		

		string ScoreLabel = "Score : ";
		
		
		
		GUI.Label (new Rect (10f, 10f, 150, 30), ScoreLabel + score);
		
		
		if (GUI.Button  (new Rect(Screen.width/ 2-100f,Screen.height/ 50f,200f,50f),"Main Menu")){
			
			if(PlayerPrefs.GetInt ("score") < score)
				
			{
				//Game is over here, so save high score
				PlayerPrefs.SetInt("score",score);
			}
			
			
			Application.LoadLevel (0);
		}

		if (GUI.Button (new Rect (Screen.width - 150f, Screen.height / 50f, 55f, 50f), "Pause")) {
			
			
			
			Time.timeScale = 0f;
		}
		
		if (GUI.Button (new Rect (Screen.width - 95f, Screen.height / 50f, 55f, 50f), "Play")) {
			
			
			
			Time.timeScale = 1f;
		}

		if (GUI.Button (new Rect (Screen.width - 250f, Screen.height / 50f, 100f, 50f), "Restart")) {
			
			
			
			Application.LoadLevel(8);
		}
		
		
	}

	// Update is called once per frame
	void Update () {

		//go back to the main menu if esc button is pressed
		if (Input.GetKeyDown (KeyCode.Escape)){
			
			if(PlayerPrefs.GetInt ("score") < score)
				
			{
				//Game is over here, so save high score
				PlayerPrefs.SetInt("score",score);
			}
			
			Application.LoadLevel (0);
		}


		
		//Calculate how long I have been playing for in milliseconds
		currentTime = Time.time - startTime;
	
	}





	

}
