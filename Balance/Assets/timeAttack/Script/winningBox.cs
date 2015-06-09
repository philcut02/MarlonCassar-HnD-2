using UnityEngine;
using System.Collections;

public class winningBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "box1")
		{
			Application.LoadLevel(10);
			//If cube hits water, Game Over
			


		}

		if(col.gameObject.tag == "box2")
		{
			Application.LoadLevel(10);
			//If cube hits water, Game Over
			
		}
	}
}
