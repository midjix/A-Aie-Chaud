using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parcour : MonoBehaviour
{
    public float speed = 10;
    public GameObject personnage;
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    
}
