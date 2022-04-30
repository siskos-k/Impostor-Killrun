using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariableStorage : MonoBehaviour
{
   //public GameObject pog;
   //public GameObject UI;
   //public GameObject EndButtons;
   public static int killcount;
   public static int won;
   public static int sceneChange;
   public static int killmeme;
   public static int timeUp;

public static int level = 1;
   //public static int level1passed = 0;
   //public static int level1time = 80;

//public static int level2;
   public static int level2passed = 0;
  // public static int level2time = 80;

//public static int level3;
   public static int level3passed = 0;
   public static int level3time = 80;

//public static int level4;
   public static int level4passed = 0;
   public static int level4time = 80;

    public static int musicisplaying = 0;
   
   public static float SoundVolume;

   
   /*
   PLAYER PREFS
   PUBLIC STATIC BOOL LEVEL(I)PASSED
   PUBLIC VOID LEVEL(I).WON
   LEVELTRACKER

   IF LEVELTRAKER == LEVEL(I) && WON
        LEVEL(I).WON();
    
    LEVELWON()
        set something to 1 because 1 is int
        //player prefs have ints, very cool
        save it to playerpref("levelxpassed")
        check on start if any level is passed
        if they are display time it took


    there are no bool PlayerPrefs. Fuck this engine
    public void intToBool()
    {

    }
   */
   public static bool returnedToKill;
    void Start()
    {

        //EndButtons.SetActive(false);
        //UI.SetActive(true);
        //pog.SetActive(false);
        killcount = 0;
        won = 0;
        timeUp = 0;
    }

    // Update is called once per frame
    void Update()
    {
       /*if(killcount == 5)
       {
           win();
       }
       if(timeUp == 1){
           lose();
           //timeUp =0;
       }*/
       Debug.Log("Global won = "+won);
    }
    void win()
    {
        Debug.Log("POGGERS");
        won = 1;
        
        //pog.SetActive(true);
    }

    void lose()
    {
        Debug.Log("poggen't");
    }
}
