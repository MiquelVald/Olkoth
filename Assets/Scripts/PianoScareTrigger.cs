using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoScareTrigger : MonoBehaviour
{
    public AudioSource pianoAudioSource;
    public AudioSource scareAudioSource;
    public AudioClip scareSound;
    public AudioClip pianoSong;

    public AudioClip ambianceSong;
    public AudioSource house;
    public bool hasBeenPlayed = false;

    void Start()
    {
        pianoAudioSource.PlayOneShot(pianoSong);
        hasBeenPlayed = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && hasBeenPlayed == false)
        {
            house.volume = 0.30f;
            house.Play();
            scareAudioSource.PlayOneShot(scareSound);
            hasBeenPlayed = true;
            pianoAudioSource.Stop();
        }
    }


}
