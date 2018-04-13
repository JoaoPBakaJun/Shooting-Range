using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour {

    public Text highScore;
    public float savedHighScore = 0f;
    public static float totalHighScore = 0f;


    // Update is called once per frame
    void Update () {

        savedHighScore = Score.TotalScore;

        if (savedHighScore >= EndGameMenu.savedScore)
        {
            totalHighScore = savedHighScore;       
        }
        highScore.text = totalHighScore.ToString("0");
    }
}
