using UnityEngine;
using System.Collections;

public class Box2 : MonoBehaviour
{

	//Add a reference to the audio clip
	public AudioClip box2Sound;
	public AudioClip Timer;
	bool isWinning = false;
	Vector3 dist;
	float posX;
	float posY;
	float startTime;
	float currentTime;
	float duration = 5f;

	//variable for the GUI skin
	public GUISkin stylesheet;

	void OnMouseDown ()
	{
		dist = Camera.main.WorldToScreenPoint (transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;
		
	}
	
	void OnMouseDrag ()
	{
		Vector3 curPos = 
			new Vector3 (Input.mousePosition.x - posX, 
			            Input.mousePosition.y - posY, dist.z);  
		
		Vector3 worldPos = Camera.main.ScreenToWorldPoint (curPos);
		transform.position = worldPos;
	}

	IEnumerator youwon ()
	{


		yield return new WaitForSeconds (5f);
		Application.LoadLevel (11);


		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "box1") {

			if (Box1.score >= 3) {
				startTime = Time.time;
				isWinning = true;
				GetComponent<AudioSource> ().PlayOneShot (Timer);
			}

			//save the time when I pressed play
			//StartCoroutine ("youwon");
			



		}



		if (col.gameObject.tag == "water") {
			Application.LoadLevel (10);
			//If cube hits water, Game Over
			
		}


	
	}

	void Update ()
	{

		if (isWinning) {
			currentTime = duration - (Time.time - startTime);

			if (currentTime <= 0f)
				Application.LoadLevel (11);
		}

		if (Input.GetMouseButtonDown (0)) {
			
			//play the sound
			GetComponent<AudioSource> ().PlayOneShot (box2Sound);
			
			
		}	



	}
	
	void OnGUI ()
	{

		GUI.skin = stylesheet;

		GUI.Label (new Rect (10f, 40f, 150, 30), "Timer : ");
		GUI.Label (new Rect (60f, 40f, 150, 30), currentTime.ToString ());

	}






}