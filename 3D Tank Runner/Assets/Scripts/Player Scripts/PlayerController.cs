using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private Rigidbody playerRB;
    private Quaternion startRotation =Quaternion.Euler(0,0,0);

    private void Awake()
    {
         playerRB = GetComponent<Rigidbody>();
    }

    void Start()
    {
        playerRB.rotation = startRotation;
    }
       
    void Update()
    {
       
        ControlMovementWithKeyboard();
        ChangeRotation();
    }

    private void FixedUpdate()
    {
        
        MoveTank();
       
    }

    void MoveTank()
    {
        playerRB.MovePosition(playerRB.position + speed * Time.deltaTime);
    }

    void ControlMovementWithKeyboard()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            MoveFast();
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            MoveSlow();
        }
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            MoveStraight();
           
           
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            MoveStraight();
           
           
        }
        if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            MoveNormal();
        }
        if(Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            MoveNormal();
        }
    }

    void ChangeRotation()
    {
        if (speed.x < 0)
        {
           
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -maxAngle, 0), Time.deltaTime * rotationSpeed);
           
        }
        else if (speed.x >0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, maxAngle, 0), Time.deltaTime * rotationSpeed);
           
        }
        else
        {
            transform.rotation = startRotation;
        }
    }









} // CLASS
