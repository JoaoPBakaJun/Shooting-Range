using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target100m : MonoBehaviour {

	public static float score = 0f;

	void OnCollisionEnter()
	{
		score += 100;
		Debug.Log ("Hit + 100 pts");
	}
}
