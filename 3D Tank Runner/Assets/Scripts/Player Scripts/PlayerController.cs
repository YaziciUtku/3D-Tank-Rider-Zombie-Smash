using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private Rigidbody playerRB;

    private void Awake()
    {
         playerRB = GetComponent<Rigidbody>();
    }

    void Start()
    {
       
    }

   
    void Update()
    {
        ControlMovementWithKeyboard();
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











} // CLASS
