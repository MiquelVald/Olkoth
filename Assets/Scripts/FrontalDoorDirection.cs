using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontalDoorDirection : MonoBehaviour
{
    public OpenFront openFront;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            openFront.front = true;
            openFront.back = false;
        }
    }
}
