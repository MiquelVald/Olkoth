using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOnScript : MonoBehaviour
{

    public Light scareLight;
    public AudioSource scareAudioSource;
    public AudioClip scareSound;
    private bool hasBeenPlayed;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && hasBeenPlayed == false)
        {
            scareLight.enabled = true;
            scareAudioSource.PlayOneShot(scareSound);
            hasBeenPlayed = true;
        }
    }
}
