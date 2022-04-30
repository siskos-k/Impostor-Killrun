using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncres : MonoBehaviour
{
    public GameObject Crew1;
    public GameObject Crew2;
    public GameObject Crew3;
    public GameObject Crew4;
    public GameObject Crew5;

    public int generate;
    public int newgen;
    public int prev0,prev1, prev2, prev3, prev4;

    // Start is called before the first frame update
    void Start()
    {
        Crew1.SetActive(false);
        Crew2.SetActive(false);
        Crew3.SetActive(false);
        Crew4.SetActive(false);
        Crew5.SetActive(false);

        //prev0 = 0;
        prev1 = 0;
        prev2 = 0;
        prev3 = 0;
        prev4 = 0;
        //prev5 = 0;

        generate = Random.Range(1,6);
        prev0 = generate;//prev1 = generate;

        
        if (generate == 1 && !Crew1.active ){
            Crew1.SetActive(true);
            Debug.Log("1");
        }
        if (generate == 2 && !Crew2.active){
            Crew2.SetActive(true);
            Debug.Log("2");
        }
        if (generate == 3 && !Crew3.active){
            Crew3.SetActive(true);
            Debug.Log("3");
        }
        if (generate == 4 && !Crew4.active){
            Crew4.SetActive(true);
            Debug.Log("4");
        }
        if (generate == 5 && !Crew5.active){
            Crew5.SetActive(true);
            Debug.Log("5");
        }

        //GlobalVariableStorage.killmeme = GlobalVariableStorage.killcount
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("kills: " + GlobalVariableStorage.killcount);
        //Debug.Log(prev1);

        if (GlobalVariableStorage.killcount == 1 && prev1 ==0){

            prev1 = generate;
            newgen = Random.Range(1,6);
            //Debug.Log("starting newgen is " + newgen)
            if (newgen == prev1 || newgen == prev0){
                while(newgen == prev1){
                    newgen = Random.Range(1,6);
                    //Debug.Log("attempting newgen" + newgen);
                }
            }
            prev1 = newgen;
            generate = newgen;
        }

        if (GlobalVariableStorage.killcount == 2 && prev2 == 0)
        {
        
            newgen = Random.Range(1,6);
            //Debug.Log("starting newgen is " + newgen);
            while (newgen==generate || newgen == prev1 || newgen == prev0)
                {
                newgen = Random.Range(1,6);
                //Debug.Log("attempting newgen" + newgen);
                }
                prev2 = newgen;
                generate = newgen;
        }

        if (GlobalVariableStorage.killcount == 3 && prev3 == 0)
        {
           newgen = Random.Range(1,6);
           while (newgen==generate || newgen == prev1 || newgen == prev2 || newgen == prev0)
                {
                newgen = Random.Range(1,6);
                }
            prev3 = newgen;
            generate = newgen;
           }

     if (GlobalVariableStorage.killcount == 4 && prev4 == 0)
        {
           newgen = Random.Range(1,6);
           while (newgen==generate || newgen == prev1 || newgen == prev2 || newgen == prev3 || newgen == prev0)
                {
                newgen = Random.Range(1,6);
                }
               prev4 = newgen;
               generate = newgen;
           }
            
     /*if (GlobalVariableStorage.killcount == 4)
        {
           newgen = Random.Range(1,6);
           while (newgen==generate || newgen == prev1 || newgen == prev2 || newgen == prev3 || newgen == prev4)
                {
                newgen = Random.Range(1,6);
                }
               newgen = prev4;
               generate = newgen;
           }*/

            if (generate == 1 && !Crew1.active ){
            Crew1.SetActive(true);
            Debug.Log("1");
        }
        if (generate == 2 && !Crew2.active){
            Crew2.SetActive(true);
            Debug.Log("2");
        }
        if (generate == 3 && !Crew3.active){
            Crew3.SetActive(true);
            Debug.Log("3");
        }
        if (generate == 4 && !Crew4.active){
            Crew4.SetActive(true);
            Debug.Log("4");
        }
        if (generate == 5 && !Crew5.active){
            Crew5.SetActive(true);
            Debug.Log("5");
        }

            
            
        }
        
        //Debug.Log(generate);
        //generate = Random.Range(1,6);
    }

