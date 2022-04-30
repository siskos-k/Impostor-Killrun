using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingsound : MonoBehaviour
{ 
    private AudioSource audioSource;
   // .///prwsdvja vo;jangronargasnsrkjgm akj kwj ;kwn efkWJ EFwj efkWJ EFMwkj efWEN Fwenf WEFKN wefk mWEFK.w mefW'
    private bool IsMoving;
    
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
 
    void Update()
    {
        if (Input.GetAxis("Vertical") >= 1 || Input.GetAxis("Vertical") <= -1 || Input.GetAxis("Horizontal") >= 1|| Input.GetAxis("Horizontal") <= -1) IsMoving = true; // better use != 0 here for both directions
        
        else IsMoving = false;
 
        if (IsMoving && !audioSource.isPlaying && !PauseMenu.GameIsPaused)
        {
            //Debug.Log(Input.GetAxis("Vertical")+" = vertical");
             audioSource.Play(); 
        }
        if (IsMoving) Debug.Log("Poggers");  // if player is moving and audiosource is not playing play it
        if (!IsMoving || PauseMenu.GameIsPaused /*|| tikTok*/) audioSource.Stop(); // if player is not moving and audiosource is playing stop it
    }
}