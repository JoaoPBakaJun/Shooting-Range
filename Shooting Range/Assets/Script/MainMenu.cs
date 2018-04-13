using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{

	public void PlayGame()
	{
        EndGameMenu.inMainMenu = false;
		SceneManager.LoadScene ("Level1");
        Time.timeScale = 1f;
    }
    public void PlayGame2()
    {
        EndGameMenu.inMainMenu = false;
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1f;
    }

    public void QuitGame()
	{
		Debug.Log ("Exiting game");
		Application.Quit ();
	}
}
