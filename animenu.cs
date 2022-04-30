using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animenu : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        //animator = GetComponent<Animator>();
        animator.SetBool("isWalking", true);

        if (!Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("d"))
        {
            animator.SetBool("isWalking", false);
        }
    }
}
