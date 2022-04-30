using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class rank : MonoBehaviour
{
    public TextMeshProUGUI rankPlayer;
    public TextMeshProUGUI rankMessage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int totaltime = PlayerPrefs.GetInt("Level1") + PlayerPrefs.GetInt("Level2") + PlayerPrefs.GetInt("Level3") + PlayerPrefs.GetInt("Level4");
        if(PlayerPrefs.GetInt("Level1Complete") == 1 &&PlayerPrefs.GetInt("Level2Complete") == 1 &&PlayerPrefs.GetInt("Level3Complete") == 1 &&PlayerPrefs.GetInt("Level4Complete") == 1)
        {
            if (totaltime >= 110)
            {
                rankPlayer.text = "epic gamer (top)";
            }
            if (totaltime >= 124)
            {
                rankPlayer.text = "big pp";
                rankMessage.text = "You are not great. Good, but not great.";

            }
            if (totaltime >= 130)
            {
                rankPlayer.text = "Not embarassing";
                rankMessage.text = "You have potential to suck less.";
            }
            if (totaltime >= 140)
            {
                rankPlayer.text = "really bad";
                rankMessage.text = "Sometimes people are just not lucky. Not you tho you just suck";
            }
            if (totaltime >=153)
            {
                rankPlayer.text = "Embarassing";
                rankMessage.text = "Wow, did you really do that bad? I coded that rank as a joke...";
            }
            
            
            
            
        }
    }
}
