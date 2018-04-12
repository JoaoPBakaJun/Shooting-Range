using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target200m : MonoBehaviour {


	public static float score;

	void OnCollisionEnter()
	{
		score += 400;
		Debug.Log ("Hit + 400 pts");
	}


	/*public void totalScores(float scoreB)
	{
		float totalScore;
		totalScore = score + scoreB ;
	}*/
	
	// Update is called once per frame
	void Update () {
	}
}
