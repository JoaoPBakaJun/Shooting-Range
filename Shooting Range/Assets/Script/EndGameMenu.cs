using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{

    public static bool gameEnd = false;
    public static bool inMainMenu = false;
    public static float savedScore = 0f;
    public GameObject endGameMenu;
	
	// Update is called once per frame
	void Update ()
    {
        if (TimeLeft.timeLeftA <= 0)
        {
            EndGame();
            
        }
    }


    void EndGame()
    {
        Screen.lockCursor = false;
        endGameMenu.SetActive(true);
        Time.timeScale = 0f;
        gameEnd = true;
    }


    public void LoadMenu()
    {
        Target50m.score = 0f;
        Target100m.score = 0f;
        Target150m.score = 0f;
        Target200m.score = 0f;
        savedScore = HighScore.totalHighScore;
        inMainMenu = true;
        gameEnd = false;
        endGameMenu.SetActive(false);
        TimeLeft.timeLeftA = 60f;
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
        Debug.Log("MenuLoading");
    }

	public void ExitGame()
	{

		Application.Quit ();
		Debug.Log ("ExitingGame");
	}
}
