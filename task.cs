using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class task : MonoBehaviour
{
    
    public PlayerMovement Player;
    public bool doestask = false;
    void Update()
    {

    if (doestask==true){

        Debug.Log("Downloading");
        StartCoroutine(Test());
         
        }

    void OnMouseOver(){ 
    {
        if(Input.GetMouseButtonUp(0))
        {
            doestask = true;
        }
    }

    }
    

    }
     IEnumerator Test(){
        yield return new WaitForSeconds (3);
        Debug.Log("Wait is over nigga");
        doestask = false;
    }
}
/*
public class DOWNLOADING : MonoBehaviour
{    

    public bool doing_task;
    void update(){ 
        
        void OnMouseOver(){
            if(Input.GetMouseButtonUp(0)){
                doing_task = true;
                StartCoroutine(Test());
                Debug.Log("start download");
                doing_task = false;
            }
    }
    }
    IEnumerator Test(){
        yield return new WaitForSeconds (10);
        Debug.Log("Wait is over nigga");
    }

}
*/
    

