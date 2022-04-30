using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOWNLOADING : MonoBehaviour
{    

    public PlayerMovement Player;

    public bool doing_task;
    void update(){ 
        
        void OnMouseOver(){
            if(Input.GetMouseButtonUp(0)){
                doing_task = true;
                
                
            }
        }
        if (doing_task == true){
                StartCoroutine(Test());
                Debug.Log("starting download...");
        }
    }
    IEnumerator Test(){
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over nigsga");
        doing_task = false;
    }

}