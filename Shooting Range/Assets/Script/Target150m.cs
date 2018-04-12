using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target150m : MonoBehaviour {


	public static float score;

	void OnCollisionEnter()
	{
		score += 200;
		Debug.Log ("Hit + 200 pts");
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
