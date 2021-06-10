using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoScareTrigger : MonoBehaviour
{
    public AudioSource pianoAudioSource;
    public AudioSource scareAudioSource;
    public AudioClip scareSound;
    public AudioClip pianoSong;
    private bool hasBeenPlayed;

    void Start()
    {
        pianoAudioSource.PlayOneShot(pianoSong);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && hasBeenPlayed == false)
        {
            scareAudioSource.PlayOneShot(scareSound);
            hasBeenPlayed = true;
            pianoAudioSource.Stop();
        }
    }


}
