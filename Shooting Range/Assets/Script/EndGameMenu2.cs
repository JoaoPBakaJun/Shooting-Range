using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu2 : MonoBehaviour {

    public static bool gameEnd = false;
    public static bool inMainMenu = false;
    public static float savedScore = 0f;
    public float extraTime = 5f;
    public GameObject endGameMenu;

    // Update is called once per frame
    void Update()
    {
        if (Gun2.currentMag <= 0 && AK2.currentMag <= 0)
        {
            extraTime -= Time.deltaTime;
            if(extraTime <= 0)
            {
                EndGame();
            }
        }
    }


    void EndGame()
    {
        Screen.lockCursor = false;
        endGameMenu.SetActive(true);
        Time.timeScale = 0f;
        gameEnd = true;
    }

    /* public void Resume()
     {
         Screen.lockCursor = true;
         endGameMenu.SetActive(false);
         Time.timeScale = 1f;
         gameEnd = false;
     }*/

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
        savedScore = HighScore2.totalHighScore;
        inMainMenu = true;
        gameEnd = false;
        endGameMenu.SetActive(false);
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
        Debug.Log("MenuLoading");
    }

    public void ExitGame()
    {

        Application.Quit();
        Debug.Log("ExitingGame");
    }
}
