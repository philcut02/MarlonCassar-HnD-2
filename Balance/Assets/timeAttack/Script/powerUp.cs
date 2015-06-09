using UnityEngine;
using System.Collections;

public class powerUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator slowTime ()
	{

		GetComponent<Renderer>().enabled = false;	
			Time.timeScale = 0.1f;

		yield return new WaitForSeconds (0.5f);
		Time.timeScale = 1f;
		Destroy (this.gameObject);

	}

	void OnMouseDown(){
		// this object was clicked - do something
		//Destroy (this.gameObject);
		//Time.timeScale = 0.1f;
		StartCoroutine ("slowTime");
	}   
}
