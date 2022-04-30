using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject PauseSettingsUI;

    // Update is called once per frame

    void Start(){
        Resume();
    }
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseSettingsUI.SetActive(false);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu(){
        //Debug.Log("menu");
        SceneManager.LoadScene("MENU");
    }
    public void QuitGame(){
        //Debug.Log("quit.pog");
        Application.Quit();
    }

     public void SetQuality (int qualityIndex)
   {
     QualitySettings.SetQualityLevel(qualityIndex);
   }
}
