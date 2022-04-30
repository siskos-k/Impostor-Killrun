using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverControl : MonoBehaviour
{

   public void  Mainmenuback ()
   {
       SceneManager.LoadScene(0);
   } 

    public void KillMenuLoad()
    {
        SceneManager.LoadScene(0);
        GlobalVariableStorage.returnedToKill = true;
        //MainMenu.killmenu();
        //MainMenu.SetActive(false);
        //killrunmenu.SetActive(true);
    }
    public void PlayLevel1 ()
   {
       SceneManager.LoadScene(3);
   } 


   public void QuitGame ()
   {
       Application.Quit();
       Debug.Log("pog");
   }
   public void SetQuality (int qualityIndex)
   {
       QualitySettings.SetQualityLevel(qualityIndex);
   }
}
