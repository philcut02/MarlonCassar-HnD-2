using UnityEngine;
using System.Collections;

public class boxGenerator : MonoBehaviour
{
	
	//16.public gameobject varuiable for obstacles
	//Implementing multiple obstacles
	public GameObject[] obstacles;
	
	//declare a variable for the pothole x position
	float timeGap;
	
	
	//Declare a co-routine which will run  all the time during the update
	IEnumerator generateObstacles ()
	{
		while (true) {
			
			//set a random number for the obstacle position 
			timeGap = 2f;
			
			//obstacle choosen random number
			int obstacleChooser = (int)Mathf.Floor (Random.Range (0f, 0f));
			Debug.Log (obstacleChooser);
			
			//choose the first item in the obstacle array
			Instantiate (obstacles [obstacleChooser], this.transform.position, Quaternion.identity); 
			
			yield return new WaitForSeconds (timeGap);
		}
	}
	
	// Use this for initialization
	void Start ()
	{
		
		StartCoroutine ("generateObstacles");
		
	}
	
	//16.
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
