  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    [SerializeField]

    private Transform target;
    [SerializeField]
    private float smoothness = 0.125f;

    [SerializeField]
    private Vector3 offset;
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothness);
        transform.position = smoothedPosition;
    }
}