using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpostorKill : MonoBehaviour
{
    public GameObject Impostor;
    public GameObject Crewmate;

    public AudioSource killsound;

    public SkinnedMeshRenderer m;
    public SkinnedMeshRenderer ded;
    public SkinnedMeshRenderer dedbag;

    public bool isdead;

    public float Distance_;
    

    //public int callToKillcount;

    public ParticleSystem blood;
    
    // Start is called before the first frame update
    void Start()
    {
        //SkinnedMeshRenderer m = GetComponent<SkinnedMeshRenderer>();
        //GetComponent <ParticleSystem>().Play ();
        m.enabled = true;
        dedbag.enabled = false;
        ded.enabled = false;
        Distance_ = Vector3.Distance(Impostor.transform.position,Crewmate.transform.position);
        isdead = false;       
    }

    void Update()
    {
        
        Distance_ = Vector3.Distance(Impostor.transform.position,Crewmate.transform.position);
       // GlobalVariableStorage.killcount = callToKillcount;
      //  Debug.Log(GlobalVariableStorage.killcount);

        if (Distance_ < 2 && !isdead)
        {
           if ( Input.GetKeyDown("q"))
           {
               kill();
           }
            
        }
        //SkinnedMeshRenderer m = GetComponent<SkinnedMeshRenderer>();
       // m.enabled = false;
    }
    /*void OnCollisionEnter(Collision col)
    {
        //Debug.Log(gameObject.name + " collided with " + col.gameObject.name);
    }*/
    // Update is called once per frame
    /*void OnTriggerEnter( Collider other)
    {
     //  Debug.Log(gameObject.name + " collided with " + other.gameObject.name);

        if(other.tag == "impostor")
        { 
            //SkinnedMeshRenderer m = other.GetComponent<SkinnedMeshRenderer>();
            */
            void kill()
            {
            killsound.Play();
            m.enabled = false;
            ded.enabled = true;
            dedbag.enabled = false;
            blood.Play();
            isdead = true;
            GlobalVariableStorage.killcount ++;
            }
            /*
        }*/
}
