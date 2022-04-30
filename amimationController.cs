using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amimationController : MonoBehaviour
{
    Animator animator;
//    bool playing = false;
    //public AudioSource step;
    //CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //cc = GetComponent<CharacterController>();
        //Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        //playing = true;
        animator.SetBool("isWalking", true);
        //if(!playing)
        
       // step.Stop();
       // }

        if (!Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("d"))
        {
             animator.SetBool("isWalking", false);
             //step.Stop();
             //playing = false;
        }
        
            
        
    }
}
