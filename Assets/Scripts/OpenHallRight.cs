using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHallRight : MonoBehaviour
{
    public bool testDoor = false, isTheDoorOpen = false, front = false, back = true;
    public float doorOpenAngle = 90f, doorClosingAngle = 0f, smooth = 2f;
    public void ChangeDoorRHallState()
    {
        isTheDoorOpen = !isTheDoorOpen;
    }
    // Update is called once per frame
    void Update()
    {
        if (isTheDoorOpen)
        {
            if (back)
            {
                Quaternion targetRotationOpen = Quaternion.Euler(0, doorOpenAngle, 0);
                transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);
            }
            else if (front)
            {
                Quaternion targetRotationOpen = Quaternion.Euler(0, -90, 0);
                transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);
            }
            else
            {
                Quaternion targetRotationOpen = Quaternion.Euler(0, 0, 0);
                transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);
            }

        }
        else
        {
            Quaternion targetRotationClosed = Quaternion.Euler(0, doorClosingAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationClosed, smooth * Time.deltaTime);
        }

        if (testDoor)
        {
            ChangeDoorRHallState();
            testDoor = false;
        }
    }
}
