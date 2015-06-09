using UnityEngine;
using System.Collections;

public class powerUpScore : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "box")
			
			//Increase the score by 1
			playScreen.score+=5;
			Destroy(this.gameObject);

			
		}
	}

