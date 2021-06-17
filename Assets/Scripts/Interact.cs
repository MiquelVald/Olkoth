using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interact : MonoBehaviour
{
    public OpenFront openFront;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                openFront.ChangeDoorState();
            }
        }
    }
    void kedijooo()
    {
        Debug.Log("haaa");
    }

}
