using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    public GameObject bloodEffect;
    public AudioClip[] zombieSmashSounds;
    private float speed;
    

    private void Awake()
    {
        speed = Random.Range(1f, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Instantiate(bloodEffect, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(zombieSmashSounds[0], transform.position);
            gameObject.SetActive(false);
          
            
        }

        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(bloodEffect, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(zombieSmashSounds[1], transform.position);

            gameObject.SetActive(false);
           
        }

    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<PlayerController>().transform.position, speed * Time.deltaTime);

        if(transform.position.y < -10f)
        {
            gameObject.SetActive(false);
        }
    }

}
