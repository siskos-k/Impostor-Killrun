using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIenemy : MonoBehaviour
{
    public float walkMoveForce = 0f;
    public float runMoveForce = 0f;
    public float moveForce = 0f;
    public LayerMask whatIsPlayer;
    public LayerMask whatIsObstacle;
    private Rigidbody rbody;
    public float wallCheckDist = 0f;
    private Vector3 moveDir;
    private bool targetFound;

    public GameObject impostor;
    public float distanceFromTarget = 0f;
    public float safeDistance = 0f;

    public float runTurnRate = 0f;
    private float runTimeStamp = 0f;
    public float runTurnDistanceCheck = 0f;


    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        moveDir = ChoseDirection();
        transform.rotation = Quaternion.LookRotation(moveDir);
        moveForce = walkMoveForce;
        runTurnRate = Random.Range(0.5f, 1.5f);


    }

    // Update is called once per frame
    void Update()
    {

        distanceFromTarget = Vector3.Distance(transform.position, impostor.transform.position);

        if (targetFound)
        {
            Shoot();
        }
        else
        {
            LookForTarget();
        }
        
    }

    void Shoot()
    {
        Debug.Log("pew pew");
        //nah
        Hide();
    }

    void Hide()
    {
        if(distanceFromTarget < safeDistance)
        {
            RunToHide();
        }
        else
        {
            moveForce = walkMoveForce;
            targetFound = false;
            moveDir = ChoseDirection();
            transform.rotation = Quaternion.LookRotation(moveDir);
        }
        
    }

    void RunToHide()
    {
        rbody.velocity = moveDir * moveForce;
        if(Time.time > runTimeStamp)
        {
            if(Physics.Raycast(transform.position, transform.right, runTurnDistanceCheck, whatIsObstacle))
            {
                moveDir = -transform.right;
                transform.rotation = Quaternion.LookRotation(moveDir);
            }
             else if(Physics.Raycast(transform.position, -transform.right, runTurnDistanceCheck, whatIsObstacle))
            {
                moveDir = transform.right;
                transform.rotation = Quaternion.LookRotation(moveDir);
            }
            else
            {
                moveDir = ChoseDirectionLR();
                transform.rotation = Quaternion.LookRotation(moveDir);
            }
            runTurnRate= Random.Range(0.5f, 1.5f);
            runTimeStamp = Time.time + runTurnRate;
        }
    }

    Vector3 ChoseDirectionLR(){
        System.Random ran = new System.Random();
        int i = ran.Next(0, 1);
        Vector3 temp = new Vector3();

        if (i ==0)
        {
            temp = transform.right;
        }  
        else if(i==1)
        {
            temp = -transform.right;
        }
       
        return temp;
    }

    Vector3 ChoseDirection(){
        System.Random ran = new System.Random();
        int i = ran.Next(0, 3);
        Vector3 temp = new Vector3();

        if (i ==0)
        {
            temp = transform.forward;
        }  
        else if(i==1)
        {
            temp = -transform.forward;
        }
        else if(i==2)
        {
            temp = transform.right;
        }
        else if(i==3)
        {
            temp = -transform.right;
        }
        return temp;
    }

    void LookForTarget()
    {
        Move();
        targetFound = Physics.Raycast(transform.position, transform.forward, Mathf.Infinity, whatIsPlayer);

    }

    void Move()
    {
        rbody.velocity = moveDir * moveForce;
        if(Physics.Raycast(transform.position, transform.forward, wallCheckDist, whatIsObstacle))
        {
            moveDir = ChoseDirection();
            transform.rotation = Quaternion.LookRotation(moveDir);
        }
    }
}


