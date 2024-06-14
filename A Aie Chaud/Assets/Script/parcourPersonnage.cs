using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parcourPersonnage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.name == "Sphere" || hit.gameObject.name == "Sphere (1)" || hit.gameObject.name == "Sphere (2)" || hit.gameObject.name == "Sphere (3)" || hit.gameObject.name == "Sphere (4)" || hit.gameObject.name == "Sphere (5)" || hit.gameObject.name == "Sphere (6)" || hit.gameObject.name == "Sphere (7)" || hit.gameObject.name == "Sphere (8)" || hit.gameObject.name == "Sphere (9)" || hit.gameObject.name == "Sphere (10)" || hit.gameObject.name == "Sphere (11)" || hit.gameObject.name == "Sphere (12)")
        {
            Vector3 newPosition = new Vector3(14.57131f, 76.05f, 0.1097848f);
            this.transform.position = newPosition;
        }
    }
}
