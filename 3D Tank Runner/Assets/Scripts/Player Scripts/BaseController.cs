using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{// CLASS
    protected float rotationSpeed = 10f;
    protected float maxAngle = 10f;

    public Vector3 speed;
    public float x_Speed = 8f, z_Speed = 12f;
    public float accelerated = 15f, deccalerated = 10f;
    public float low_Sound_Pitch, normal_Sound_Pitch, high_Sound_Pitch;
    public AudioClip engine_On_Sound, engine_Off_Sound;
    private AudioSource soundManager;
    private bool is_Slow;

    private void OnEnable()
    {
        speed = new Vector3(0, 0, z_Speed);
        soundManager = GetComponent<AudioSource>();
    }

    private void Awake()
    {
        speed = new Vector3(0, 0, z_Speed);
        
    }

    protected void MoveLeft()
    {
        speed = new Vector3(-x_Speed/ 2f, 0f, speed.z);
    }

    protected void MoveRight()
    {
        speed = new Vector3(x_Speed / 2f, 0f, speed.z);
    }

    protected void MoveStraight()
    {
        speed = new Vector3(0f, 0f, speed.z);
    }

    protected void MoveNormal()
    {
        if (is_Slow)
        {
            is_Slow = false;
            soundManager.Stop();
            soundManager.clip = engine_On_Sound;
            soundManager.volume = 0.3f;
            soundManager.Play();
        }
        speed = new Vector3(speed.x, 0f, z_Speed);
    }


protected void MoveSlow()
    {
        if (!is_Slow)
        {
            is_Slow = true;
            soundManager.Stop();
            soundManager.clip = engine_Off_Sound;
            soundManager.volume = 0.5f;
            soundManager.Play();
        }
        speed = new Vector3(speed.x, 0f, deccalerated);
    }


 protected void MoveFast()
    {
        speed = new Vector3(speed.x, 0f, accelerated);
    }

















} // CLASS