using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlooding : MonoBehaviour
{
    ParticleSystem myParticleSystem;
    public AudioSource source;
    private bool pluieOff = true;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        myParticleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Angle(Vector3.down, transform.forward) <= 90f)
        {
            myParticleSystem.Play();
            if (pluieOff)
            {
                PlayPluieSound();
            }
        }
        else
        {
            myParticleSystem.Stop();
            pluieOff = true;
            source.Stop();
        }
    }

    void PlayPluieSound()
    {
        if(pluieOff)
        {
            source.Play();
            pluieOff = false;
        }
        
    }
}
