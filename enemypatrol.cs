using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypatrol : MonoBehaviour
{ 
public Transform[] target;
public float speed;
public float smooth = 1f;
private int current;
private Quaternion targetRotation;
public SkinnedMeshRenderer Player;
public ParticleSystem blood;
public bool isblue = true;
bool killed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.enabled){

        if(!isblue){
        if(transform.position.z != target[current].position.z) //|| transform.position.z != target[current].position.z+1 || transform.position.z != target[current].position.z-1 )
        {
           // Debug.Log("no");
            Vector3 pos = Vector3.MoveTowards(transform.position,target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
            
        }
        //if(transform.position.x==target[current].position.x)
        else
        {
           
            current = current+1;
            targetRotation = Quaternion.LookRotation(-transform.forward, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smooth * Time.deltaTime);


        }
        if (current ==2){
            current = 0;
            }

        //Debug.Log(current);
        }





        if(isblue){ 

        if(transform.position.x != target[current].position.x) //|| transform.position.z != target[current].position.z+1 || transform.position.z != target[current].position.z-1 )
        {
            //Debug.Log("not hit");
            Vector3 pos = Vector3.MoveTowards(transform.position,target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
            
        }
        //if(transform.position.x==target[current].position.x)
        else
        {
            current = current+1;
            //ebug.Log("we hit bois");
            targetRotation = Quaternion.LookRotation(-transform.forward, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
           

        }
        
        if (current ==2){
            current = 0;
            }

        //Debug.Log("current = "+current);
        //Debug.Log("PlayerPos = "+transform.position.x);
        //Debug.Log("WallPos = "+target[current].transform.position.x);
        }





        }
    }
}
