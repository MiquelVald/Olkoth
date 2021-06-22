using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontalDoorDirection : MonoBehaviour
{
    public OpenFront openFront;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               // openFront.ChangeDoorState();
            }
            openFront.front = true;
            openFront.back = false;
        }
    }

}
