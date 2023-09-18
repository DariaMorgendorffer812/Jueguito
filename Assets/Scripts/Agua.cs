using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        GetComponent<AudioSource>().Play();

    }

    void OnTriggerExit(Collider collision)
    {
        GetComponent<AudioSource>().Stop();

    }

}
