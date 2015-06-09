using UnityEngine;
using System.Collections;

public class muteButton : MonoBehaviour {

	public bool mutesound;

	void start(){
		mutesound = false;

	}

	//public void PressMuteButton()
	//{
	//	Debug.Log ("mute button pressed");
	//}


	void OnMouseDown()
	{

		if (mutesound)
		{AudioListener.pause=true;
			mutesound = false;
		}
		else
		{
			AudioListener.pause = false;
			mutesound = true;
		}
	}

		
		}

