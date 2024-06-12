using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour

{

    public int speed = 1;
    public int speed_run = 1;
    static Animator anim;
    Rigidbody rb;
    BoxCollider controller;

void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.Z))
        {
            if (Input.GetKey (KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * speed_run * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, (float)0.5, 0), ForceMode.Impulse);
        }
    }
}

