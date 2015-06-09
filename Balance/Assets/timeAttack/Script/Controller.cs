using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float boxSpeed;
	// Use this for initialization

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//14.Move the obstacle to the left
		transform.Translate (new Vector3 (0f, -1f, 0f) * boxSpeed  * Time.deltaTime);
		
		//15.if the obstacle position is -7 delet the obstacle
		if(transform.position.x <-184f ){
			Destroy(this.gameObject);
			
		}
	
	}
}
