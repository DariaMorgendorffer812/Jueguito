using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class snapshot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [SerializeField] AudioMixerSnapshot snapshot1;
    [SerializeField] AudioMixerSnapshot snapshot2;
    private void OnTriggerEnter(Collider other)
    {
        //Cuando entra en el área del cubo invisible
        snapshot2.TransitionTo(1);
    }
    private void OnTriggerExit(Collider other)
    {
        //Cuando sale del el área del cubo invisible
        snapshot1.TransitionTo(1);
    }
}
