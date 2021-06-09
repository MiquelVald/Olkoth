using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoScareTrigger : MonoBehaviour
{

    public AudioSource scareAudioSource;
    public AudioClip scareSound;
    private bool hasBeenPlayed;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && hasBeenPlayed == false)
        {
            scareAudioSource.PlayOneShot(scareSound);
            hasBeenPlayed = true;
        }
    }


}
