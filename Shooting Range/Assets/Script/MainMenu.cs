using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{

    void Start()
    {
       // Score.TotalScore = 0f;
    }

	public void PlayGame()
	{
        EndGameMenu.inMainMenu = false;
		SceneManager.LoadScene ("Level1");
	}

	public void QuitGame()
	{
		Debug.Log ("Exiting game");
		Application.Quit ();
	}
}
