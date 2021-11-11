using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveObstacles : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int damage = 20;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // DEAL DAMAGE TO THE PLAYER

            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

       

            gameObject.SetActive(false);
        }
    }














}//CLASS
