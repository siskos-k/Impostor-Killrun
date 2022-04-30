using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckHighScore : MonoBehaviour
{
    public TextMeshProUGUI level1;
   // public int cur1;
    public TextMeshProUGUI level2;

    public TextMeshProUGUI level3;
    public TextMeshProUGUI level4;
    // Start is called before the first frame update
    void Start()
    {
       // PlayerPrefs.SetInt("Level1Complete", 1);
        //PlayerPrefs.SetInt("Level2Complete", 1);
        //PlayerPrefs.SetInt("Level3Complete", 1);
       //  PlayerPrefs.SetInt("Level4Complete", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
   /* if(Input.GetKeyDown("space"))
       {
           PlayerPrefs.DeleteAll();
       }
    */


        
            if(PlayerPrefs.GetInt("Level1")!= 0)
            {
                level1.text = "0:"+PlayerPrefs.GetInt("Level1").ToString();
            }
            
            
             if(PlayerPrefs.GetInt("Level2")!= 0)
            {
                level2.text = "0:"+PlayerPrefs.GetInt("Level2").ToString();
            }

             if(PlayerPrefs.GetInt("Level3")!= 0)
            {
                level3.text = "0:"+PlayerPrefs.GetInt("Level3").ToString();
            }

             if(PlayerPrefs.GetInt("Level4")!= 0)
            {
                level4.text = "0:"+PlayerPrefs.GetInt("Level4").ToString();
            }
            
            
        
    }
}
