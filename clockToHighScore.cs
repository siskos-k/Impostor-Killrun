using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockToHighScore : MonoBehaviour
{

    public int seconds;
    public static int currentTime;
    public static int currentTime2;
    public static int currentTime3;
    public static int currentTime4;
    public bool takingAway = false;

    // Start is called before the first frame update
    void Start()
    {
        seconds = 0;
        takingAway = false;
        //Debug.Log(PlayerPrefs.GetInt("Level1"));
    }

    // Update is called once per frame
    void Update()
    {
        
        if(GlobalVariableStorage.won!=1 && GlobalVariableStorage.timeUp == 0 && takingAway==false)
       {
           StartCoroutine(TikTok());
       }
     





        if(GlobalVariableStorage.won == 1 && GlobalVariableStorage.level == 1)
        {
                currentTime = seconds;
            
            if (currentTime <  PlayerPrefs.GetInt("Level1") || PlayerPrefs.GetInt("Level1")==0)
            {
               //GlobalVariableStorage.level1time = currentTime;
                PlayerPrefs.SetInt("Level1", currentTime);
                PlayerPrefs.SetInt("Level1Complete", 1);
            }
        }


        if(GlobalVariableStorage.won == 1 && GlobalVariableStorage.level == 2)
        {
                currentTime2 = seconds;
            
            if (currentTime2 <  PlayerPrefs.GetInt("Level2") || PlayerPrefs.GetInt("Level2")==0)
            {
               //GlobalVariableStorage.level1time = currentTime;
                PlayerPrefs.SetInt("Level2", currentTime2);
                PlayerPrefs.SetInt("Level2Complete", 1);
            }
        }

         if(GlobalVariableStorage.won == 1 && GlobalVariableStorage.level == 3)
        {
                currentTime3 = seconds;
            
            if (currentTime3 <  PlayerPrefs.GetInt("Level3") || PlayerPrefs.GetInt("Level3")==0)
            {
               //GlobalVariableStorage.level1time = currentTime;
                PlayerPrefs.SetInt("Level3", currentTime3);
                PlayerPrefs.SetInt("Level3Complete", 1);
            }
        }

         if(GlobalVariableStorage.won == 1 && GlobalVariableStorage.level == 4)
        {
                currentTime4 = seconds;
            
            if (currentTime4 <  PlayerPrefs.GetInt("Level4") || PlayerPrefs.GetInt("Level4")==0)
            {
               //GlobalVariableStorage.level1time = currentTime;
                PlayerPrefs.SetInt("Level4", currentTime4);
                PlayerPrefs.SetInt("Level4Complete", 1);
            }
        }
         
         
        IEnumerator TikTok()
    {
        takingAway = true;
        seconds +=1;
        yield return new WaitForSeconds(1);

        takingAway = false;
//         Debug.Log(seconds+" secs have passed");
    }
   // Debug.Log("Public Time = "+GlobalVariableStorage.level1time);
    }
}
