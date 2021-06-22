using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackHallOpen : MonoBehaviour
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
            openHallLeft.front = false;
            openHallRight.front = false;

            openHallLeft.back = true;
            openHallRight.back = true;
        }
    }
}
