using UnityEngine;
using System.Collections;

public class boxController : MonoBehaviour {
	
	
	public float obstacleSpeed;
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//14.Move the obstacle to the left
		transform.Translate (new Vector3 (-1f, 0f, 0f) * obstacleSpeed  * Time.deltaTime);
		
		//15.if the obstacle position is -7 delet the obstacle
		if(transform.position.x <-184f ){
			Destroy(this.gameObject);
			
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "floor")
		{
			Application.LoadLevel(10);
			//If cube hits the ground, Game Over
			
		}



	}


		
		


}