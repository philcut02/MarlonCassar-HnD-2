using UnityEngine;
using System.Collections;

public class menuController : MonoBehaviour {

	public GUISkin style2;
	
	//added GUI Touch menuController
	void OnGUI ()
	{
		
		GUI.skin = style2;
		//Create a label to show High Score
		GUI.Label (new Rect (Screen.width / 2 - 200f, Screen.height / 5f, 400f,100f), "High Score:" +PlayerPrefs.GetInt("score"));
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
