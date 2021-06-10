using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFront : MonoBehaviour
{
    public bool testDoor = false, isTheDoorOpen = false, front = false, back = true, fullOpen;
    public float doorOpenAngle = 180f, doorClosingAngle = 90f, smooth = 2f;

    private AudioSource audioSource;
    public AudioClip openingSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void ChangeDoorState()
    {
        isTheDoorOpen = !isTheDoorOpen;

        if (audioSource != null)
        {
            audioSource.PlayOneShot(openingSound);
        }
    }

    void Update()
    {
        if (isTheDoorOpen)
        {
            if (front && fullOpen == false)
            {
                Quaternion targetRotationOpen = Quaternion.Euler(0, doorOpenAngle, 0);
                transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);

                if (transform.localRotation == targetRotationOpen)
                {
                    fullOpen = true;
                }
            }
            else if (back && fullOpen == false)
            {
                Quaternion targetRotationOpen = Quaternion.Euler(0, 0, 0);
                transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);

                if (transform.localRotation == targetRotationOpen)
                {
                    fullOpen = true;
                }
            }
        }
        else
        {
            Quaternion targetRotationClosed = Quaternion.Euler(0, doorClosingAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationClosed, smooth * Time.deltaTime);
            fullOpen = false;
        }

        if (testDoor)
        {
            ChangeDoorState();
            testDoor = false;
        }
    }

}
