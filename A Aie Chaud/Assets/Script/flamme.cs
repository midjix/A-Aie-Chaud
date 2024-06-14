using UnityEngine;

public class ParticleActivator : MonoBehaviour
{

    public GameObject objetFlamme;
    public GameObject canva;
    void Start()
    {
    }

    void OnTriggerEnter(Collider touch)
    {
        if (touch.gameObject.name == "flamme")
        {
            objetFlamme.gameObject.SetActive(true);
            canva.gameObject.SetActive(true);
        }
    }
}