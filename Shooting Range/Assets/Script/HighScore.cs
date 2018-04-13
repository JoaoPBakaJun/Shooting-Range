using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour {

    public Text highScore;
    public float totalHighScore = 0f;

    // Update is called once per frame
    void Update () {

        if (Score.TotalScore >= totalHighScore)
        {
            totalHighScore = Score.TotalScore;

            highScore.text = totalHighScore.ToString("0");
            
        }
	}
}
