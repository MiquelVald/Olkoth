using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip Audio;

    public bool inCanvas = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SteppingAudio()
    {
        audioSource.PlayOneShot(Audio);
        inCanvas = true;

    }
}
