using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpLava : MonoBehaviour
{
    public float speed = 21;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector2(0, speed);
    }
}
