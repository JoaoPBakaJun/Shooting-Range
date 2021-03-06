﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;


	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Tab))
		{
			if (GameIsPaused) {
				Resume ();
			} 
			else
			{
				Pause ();
			}
		}
	
	}

	public void Resume()
	{
		Screen.lockCursor = true;
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	public void Pause()
	{
		Screen.lockCursor = false;
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void LoadMenu()
	{
        Target50m.score = 0f;
        Target100m.score = 0f;
        Target150m.score = 0f;
        Target200m.score = 0f;
        Gun.raycastScore = 0f;
        Gun2.raycastScore = 0f;
        AK.raycastScore = 0f;
        AK2.raycastScore = 0f;
        EndGameMenu.savedScore = HighScore.totalHighScore;
        EndGameMenu.inMainMenu = true;
        TimeLeft.timeLeftA = 60f;
        SceneManager.LoadScene ("Menu");
		Time.timeScale = 1f;
		Debug.Log ("MenuLoading");
	}

	public void ExitGame()
	{

		Application.Quit ();
		Debug.Log ("ExitingGame");
	}



}
