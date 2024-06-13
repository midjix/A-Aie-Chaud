using UnityEngine;

public class ParticleActivator : MonoBehaviour
{

    public GameObject objetFlamme;
    void Start()
    {
    }

    void OnTriggerEnter(Collider touch)
    {
        if (touch.gameObject.name == "flamme")
        {
            objetFlamme.gameObject.SetActive(true);
        }
    }
}