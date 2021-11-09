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
        
    }

    private void FixedUpdate()
    {
        MoveTank();
    }

    void MoveTank()
    {
        playerRB.MovePosition(playerRB.position + speed * Time.deltaTime);
    }











} // CLASS
