using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winlose : MonoBehaviour
{
    public GameObject win;
    public PlayerMovement Player;
    public GameObject lose;
    public GameObject OverScreen;
    public GameObject UI;

    public int killsToWin = 1;

    public AudioSource winner;
    // Start is called before the first frame update
    void Start()
    {
        win.SetActive(false);
        lose.SetActive(false);
        OverScreen.SetActive(false);
        UI.SetActive(true);
        GlobalVariableStorage.won=0;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log( "killcount = "+GlobalVariableStorage.killcount);
       // Debug.Log( "kills to win = "+GlobalVariableStorage.killcount);
        if (GlobalVariableStorage.killcount == killsToWin)
        {
            GlobalVariableStorage.won = 1;
        }
        //Debug.Log(GlobalVariableStorage.won);
        if (GlobalVariableStorage.won == 1){
            
            if(GlobalVariableStorage.level ==1) { 
            if(PlayerPrefs.GetInt("Level1") > clockToHighScore.currentTime)
            {
               // GlobalVariableStorage.level1time = clockToHighScore.currentTime;
                PlayerPrefs.SetInt("Level1", clockToHighScore.currentTime);
            }
            }

            if(GlobalVariableStorage.level ==2) { 
            if(PlayerPrefs.GetInt("Level2") > clockToHighScore.currentTime2)
            {
               // GlobalVariableStorage.level1time = clockToHighScore.currentTime;
                PlayerPrefs.SetInt("Level2", clockToHighScore.currentTime2);
            }
            }
            //Time.timeScale = 0f;
            if(GlobalVariableStorage.level==4)
            {
                SceneManager.LoadScene(8);
            }
            else{ 
            SceneManager.LoadScene(6);
            }
            
            winner.Play();
            PauseMenu.GameIsPaused = true;
            /*win.SetActive(true);
            Player.speed=0f;
            UI.SetActive(false);
            OverScreen.SetActive(true);
            PauseMenu.GameIsPaused = true;
            Over();*/
            
        }
        if (GlobalVariableStorage.timeUp == 1){
            SceneManager.LoadScene(7);
            PauseMenu.GameIsPaused = true;
            GlobalVariableStorage.level = 0;
        }
    }
    
}
