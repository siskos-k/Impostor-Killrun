using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerr;
    public int secondLeft = 40;
    public bool takingAway;

    // Start is called before the first frame update
    void Start()
    {
        timerr.text = secondLeft.ToString();
        //Debug.Log(secondLeft);
        //textDisplay.GetComponent<Text>().text = secondLeft;
    }

    // Update is called once per frame
    void Update()
    {
       if(!takingAway && secondLeft > 0) 
       {
           StartCoroutine(TimerTake());
       }
       if(secondLeft == 0){
           GlobalVariableStorage.timeUp =1;
       }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondLeft -=1;
        timerr.text = secondLeft.ToString();
        takingAway = false;
        GlobalVariableStorage.returnedToKill=true;
    }
}
