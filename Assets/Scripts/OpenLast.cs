using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLast : MonoBehaviour
{
    public bool testDoor = false, isTheDoorOpen = false;
    public float doorOpenAnglee = 0f, doorClosingAngle = 0f, smooth = 2f;

    public AudioSource audioSource;
    public AudioClip openingSound;
    public AudioClip doorIsLockedSound;

    public bool isLocked = true;
    void Start()
    {
        isLocked = true;
        audioSource = GetComponent<AudioSource>();
    }

    public void OpenTheGodDamnDoor()
    {
        if (!isLocked)
        {
            isTheDoorOpen = !isTheDoorOpen;

            if (audioSource != null)
            {
                audioSource.PlayOneShot(openingSound);
            }
        }else 
        {
            audioSource.PlayOneShot(doorIsLockedSound);
        }

    }

    // Update is called once per frame
    public void Update()
    {
        if (isTheDoorOpen)
        {
            Quaternion targetRotationOpenn = Quaternion.Euler(0, doorOpenAnglee, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpenn, smooth * Time.deltaTime);
        }
        if (testDoor)
        {
            OpenTheGodDamnDoor();
            testDoor = false;
        }
    }
}

