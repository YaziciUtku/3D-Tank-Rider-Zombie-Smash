using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPos : MonoBehaviour
{
    public Transform playerTransform;

    void Start()
    {
        
    }
    
    
    void FixedUpdate()
    {
        Vector3 tempPos;
        tempPos.z = playerTransform.position.z;
        tempPos.y = transform.position.y;
        tempPos.x = transform.position.x;
        transform.position = tempPos;

    }
}
