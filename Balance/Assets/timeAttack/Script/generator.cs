using UnityEngine;
using System.Collections;

public class generator : MonoBehaviour
{
	
	//16.public gameobject varuiable for obstacles
	//Implementing multiple obstacles
	public GameObject[] obstacles;
	
	//declare a variable for the pothole x position
	float timeGap;

	int counter = 0;
	
	
	//Declare a co-routine which will run  all the time during the update
	IEnumerator generateBoxes ()
	{
		while (counter < 6) {
			
			//set a random number for the obstacle position 
			timeGap = 3f;
			
			//obstacle choosen random number
			int obstacleChooser = (int)Mathf.Floor (Random.Range (0f, 3f));
			Debug.Log (obstacleChooser);
			
			//choose the first item in the obstacle array
			Instantiate (obstacles [obstacleChooser], this.transform.position, Quaternion.identity); 
			
			yield return new WaitForSeconds (timeGap);

			counter++;
		}
	}
	
	// Use this for initialization
	void Start ()
	{
		
		StartCoroutine ("generateBoxes");
		
	}
	
	//16.
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
