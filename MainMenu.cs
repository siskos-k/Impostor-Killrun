using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class MainMenu : MonoBehaviour
{
public bool soundisoff = true;
//public Button soundButton;
public GameObject MainnMenu;
public GameObject KillMenu;
public AudioMixer audio;
public AudioMixer soundeff;
public GameObject soundon;
public GameObject soundof;
public AudioSource killsound;
private int volumecheck1, volumecheck2;
bool checking;
   public void SetVolume(float volume)
    {
        Debug.Log(volume);
        audio.SetFloat("volume", volume);
    }

    public void SetVolumeSound(float volumew)
    {
        Debug.Log(volumew);
       //volumecheck1 = soundeff.GetFloat("volumew");
        soundeff.SetFloat("volumew", volumew);
       // Wait();
       // volumecheck2 = soundeff.GetFloat("volumew");
//
        //checking = volumecheck1 == volumecheck2;
/*

        if(!checking)
        {
            killsound.Play();
        }*/
    }
    //public void changeImage()
    /*{
        soundButton.image.sprite = newButtonImage;
    }*/

    public void Sound()
    {
        soundisoff = !soundisoff;
        AudioListener.pause = soundisoff;
        if(soundisoff)
        {
            int sound =0;
            soundon.GetComponent<Renderer>().enabled = false;
            soundof.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            int sound = 1;
            soundon.GetComponent<Renderer>().enabled = true;
            soundof.GetComponent<Renderer>().enabled = false;
        }
    }

   public void PlayGame ()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
   } 


    public void PlayLevel1 ()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
     GlobalVariableStorage.level = 1;

   } 

   
    public void PlayLevel2 ()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
       GlobalVariableStorage.level = 2;
       
   } 

    public void PlayLevel3 ()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +4);
       GlobalVariableStorage.level = 3;
   }

   public void PlayLevel4 ()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +5);
       GlobalVariableStorage.level = 4;
   }


   public void QuitGame ()
   {
       Application.Quit();
       Debug.Log("pog");
   }
   //PlayerPrefs.SetInt()
   public void SetQuality (int qualityIndex)
   {
       QualitySettings.SetQualityLevel(qualityIndex);
   }
   public void killmenu(){
       SceneManager.LoadScene(0);
    

       //MainnMenu.SetActive(false);
       //KillMenu.SetActive(true);
      //wwwww GlobalVariableStorage.sceneChange = 0;
   }

   
    void Update(){ 
        
    if (GlobalVariableStorage.returnedToKill)
        {
            //Debug.Log("yay");
            MainnMenu.SetActive(false);
            KillMenu.SetActive(true);
            GlobalVariableStorage.returnedToKill = false;
        }
    //else Debug.Log("nooo");
    }

     IEnumerator Wait()
        {
        yield return new WaitForSeconds(1);
        }
   //void Update(){
    ///   if (GlobalVariableStorage.sceneChange == 1) killmenu();
   ///}
}
