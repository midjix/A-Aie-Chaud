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

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.name == "poulpim")
        {
            Vector3 newPosition = new Vector3(14.57131f, 76.05f, 0.1097848f);
            personnage.transform.position = newPosition;
            
        }
    }
}
