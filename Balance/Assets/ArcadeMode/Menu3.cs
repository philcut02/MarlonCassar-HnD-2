using UnityEngine;
using System.Collections;

public class Menu3 : MonoBehaviour {
	
	
	
	
	//variable for the GUI skin
	public GUISkin stylesheet;
	
	
	
	
	
	
	
	//create OnGui method
	void OnGUI ()
	{
		
		GUI.skin = stylesheet;
		
		
		
		
		if (GUI.Button (new Rect (Screen.width - 150f, Screen.height / 50f, 55f, 50f), "Pause")) {
			
			
			
			Time.timeScale = 0f;
		}
		
		if (GUI.Button (new Rect (Screen.width - 95f, Screen.height / 50f, 55f, 50f), "Play")) {
			
			
			
			Time.timeScale = 1f;
		}
		
		if (GUI.Button (new Rect (Screen.width - 250f, Screen.height / 50f, 100f, 50f), "Restart")) {
			
			
			
			Application.LoadLevel(5);
		}
		
		
		
		
	}
	
	
	
	
	
	
	
	
	
	
}


