using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
	public Text scoreText;
	public static float TotalScore = 0f;

    void start()
    {
        TotalScore = 0f;
    }

	// Update is called once per frame
	void Update () {

		TotalScore = Target50m.score + Target100m.score
			+ Target150m.score + Target200m.score;

		scoreText.text = TotalScore.ToString ();

	}
}
