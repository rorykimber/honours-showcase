using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed;
    public Vector3 offset;
   
    void LateUpdate()
    {
        Vector3 position = target.position + offset;

        Vector3 smoothPosition = Vector3.Lerp(transform.position, position, smoothSpeed);
        transform.position = smoothPosition;    

        //transform.LookAt(target);
    }
}
