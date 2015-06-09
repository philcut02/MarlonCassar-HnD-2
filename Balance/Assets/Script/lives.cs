using UnityEngine;
using System.Collections;

public class lives : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "box1")
		{
			Box1.lives--;

			
		}
}
}

