using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDoorOpen : MonoBehaviour
{

    public OpenFront openFront;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            openFront.front = false;
            openFront.back = true;
        }
    }
}
