using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour

{
    Rigidbody rb;
    BoxCollider controller;

void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            if (Input.GetKey (KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * 4 * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * 2 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 2 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 0.5f, 0), ForceMode.Impulse);
        }
    }
}

