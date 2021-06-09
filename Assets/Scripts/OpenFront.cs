using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFront : MonoBehaviour
{
    public bool isTheDoorOpen = false;
    public float doorOpenAngle = 180f;
    public float doorClosingAngle = 90f;

    public float smooth = 2f;

    public void ChangeDoorState()
    {
        isTheDoorOpen = !isTheDoorOpen;
    }

    void Update()
    {
        if (isTheDoorOpen)
        {
            Quaternion targetRotationOpen = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotationClosed = Quaternion.Euler(0, doorClosingAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationClosed, smooth * Time.deltaTime);
        }
    }
}
