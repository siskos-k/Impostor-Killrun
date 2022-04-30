using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce( 100, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        while(1>0){
            
        brrr();
        rb.AddForce( 300, 0, 0);
        brrr();
        rb.AddForce( -300, 0 , 0);
        
    }
    }
 IEnumerator brrr(){
        yield return new WaitForSeconds (5);
        //Debug.Log("Wait is over");
        //doing_task = false;
       // videoPlayer.SetActive(false);
        //Skoupidia.SetActive(false);
        //gass.SetActive(false);
        //Player.speed=5f;
    }
}