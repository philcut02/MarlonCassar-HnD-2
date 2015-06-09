using UnityEngine;
using System.Collections;

public class powerUpGenerator : MonoBehaviour
{
	
	//Create a variable for the asteroid gaem object
	public GameObject powerUp;
	
	//declare a variable for the asteroid x position
	float asteroidPosition;

	//declare a variable for the pothole x position
	float timeGap;
	
	int counter = 0;

	
	//Declare a co-routine which will run  all the time during the update
	IEnumerator createAsteroid ()
	{
		while (counter < 1) {
			
			//set a random number for the obstacle position 
			timeGap = 10f;
			
			//set a random number for the asteroid position 
			asteroidPosition = Random.Range (324f, 325f);
			
			Instantiate (powerUp, new Vector3 (asteroidPosition, 5, 250), Quaternion.identity); 
			
			yield return new WaitForSeconds (timeGap);
			
			counter++;
		}
	}
	
	// Use this for initialization
	void Start ()
	{
		
		StartCoroutine ("createAsteroid");

		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
