using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingComponent : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody;
    [SerializeField]
    private float accelerationSpeed;
    [SerializeField]
    private float rotationSpeed;
    void Start()
    {
        
    }

    void checkForInput() {
        if (Input.GetKey(KeyCode.W)) {
            rigidBody.AddForce(transform.up * accelerationSpeed);
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidBody.AddForce(-transform.up * accelerationSpeed / 3);
        }
        if (Input.GetKey(KeyCode.A) && (rigidBody.velocity != Vector2.zero)) {
            transform.Rotate(0f, 0f, rotationSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.D) && (rigidBody.velocity != Vector2.zero)) {
            transform.Rotate(0f, 0f, -rotationSpeed, Space.Self);
        }
    }
    void Update()
    {
        checkForInput();
    }
}
