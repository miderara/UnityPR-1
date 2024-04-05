using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
public Transform
        target;
    public float
        height = 2f,
        distance = 4f,
        speed = 0.25f;
    void LateUpdate()
    { 
        if(target != null)
        {
            Vector3
                pos = target.position - target.forward * distance + Vector3.up * height,
                pos_fix = Vector3.Lerp(transform.position, pos, speed);
            transform.position = pos_fix;
            transform.LookAt(target.position);
        } 
    }
}
