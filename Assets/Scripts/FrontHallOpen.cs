using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontHallOpen : MonoBehaviour
{
    public OpenHallLeft openHallLeft;
    public OpenHallRight openHallRight;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                openHallLeft.ChangeDoorLHallState();
                openHallRight.ChangeDoorRHallState();
            }
            openHallLeft.front = true;
            openHallRight.front = true;

            openHallLeft.back = false;
            openHallRight.back = false;
        }
    }
}
