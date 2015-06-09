using UnityEngine;
using System.Collections;

public class Box1 : MonoBehaviour {

	//Add a reference to the audio clip
	public AudioClip boxSound;
	public AudioClip Water;




	Vector3 dist;
	float posX;
	float posY;

	

	//variable for the GUI skin
	public GUISkin stylesheet;
	
	
	//variable for score and lives
	//declare the varaible as static variables
	public static int score;
	public static int lives;
	
	bool hit = false;
	
	// Use this for initialization
	void Start ()
	{
		lives = 5;
		score = 0;
		
	}
	
	//create OnGui method
	void OnGUI ()
	{
		
		GUI.skin = stylesheet;
		string ScoreLabel = "Score : ";
		//string LivesLabel = "Lives : ";
		
		
		GUI.Label (new Rect (10f, 10f, 150, 30), ScoreLabel + score);
		//GUI.Label (new Rect (Screen.width - 80f, 10f, 150, 30), LivesLabel + lives);
		
		if (GUI.Button  (new Rect(Screen.width/ 2-100f,Screen.height/ 50f,200f,50f),"Main Menu")){
			
			if(PlayerPrefs.GetInt ("score") < score)
				
			{
				//Game is over here, so save high score
				PlayerPrefs.SetInt("score",score);
			}
			
			
			Application.LoadLevel (0);
		}

		
			
			
		
	}

	void Update ()
	{
		
		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource>().PlayOneShot (boxSound);
			
			
		}	
		
		
		//reset score if lives are 0
		if (lives == 0) {
			
			if(PlayerPrefs.GetInt ("score") < score)
				
			{
				//Game is over here, so save high score
				PlayerPrefs.SetInt("score",score);
			}
			
			// go back to the main menu
			Application.LoadLevel (0);
			score = 0;
			lives = 5;
		}
		
		
		//go back to the main menu if esc button is pressed
		if (Input.GetKeyDown (KeyCode.Escape)){
			
			if(PlayerPrefs.GetInt ("score") < score)
				
			{
				//Game is over here, so save high score
				PlayerPrefs.SetInt("score",score);
			}
			
			Application.LoadLevel (0);
		}




	}


		
	void OnMouseDown(){
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;
		
	}
	
	void OnMouseDrag(){
		Vector3 curPos = 
			new Vector3(Input.mousePosition.x - posX, 
			            Input.mousePosition.y - posY, dist.z);  
		
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		transform.position = worldPos;
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "stand")
		{
			if (hit == false){
				score++;
				hit = true;
			}
			//Increase the Score by 1;
		
		}

		if(col.gameObject.tag == "box1")
		{
			if (hit == false){
				score++;
				hit = true;
			}
			//Increase the Score by 1;;
			
		}


		if(col.gameObject.tag == "water")
		{

			Application.LoadLevel(10);
			GetComponent<AudioSource> ().PlayOneShot (Water);
		

			
		}
	}


}