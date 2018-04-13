using UnityEngine.UI;
using UnityEngine;

public class TimeLeft : MonoBehaviour {

	public Text timeLeft;
	public static float timeLeftA = 60f;


	// Update is called once per frame
	void Update () {

		timeLeftA -= Time.deltaTime;


		timeLeft.text = timeLeftA.ToString ("0");


	}
}
