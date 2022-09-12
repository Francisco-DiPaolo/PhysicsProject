using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        InputToMove();
    }

    void InputToMove()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            rb.AddTorque(Vector3.up * speed);
            speed += 100;
        }
    }
}
