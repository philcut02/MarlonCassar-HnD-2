using UnityEngine;
using System.Collections;

public class countdown : MonoBehaviour {

	float timeLimit = 5.0f; // 10 seconds.
	void Update()
	{
		// translate object for 10 seconds.
		if(timeLimit > 0.0f) {
			// Decrease timeLimit.
			timeLimit -= Time.deltaTime;
			// translate backward.
			transform.Translate(Vector3.back * Time.deltaTime, Space.World);
			Debug.Log(timeLimit);


		}
	}
}
