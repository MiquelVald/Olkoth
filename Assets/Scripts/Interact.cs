using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interact : MonoBehaviour
{
    public string interactButton;
    public float interactDistance = 3f;
    public LayerMask interactLayer; //Filter to interact with certain objects

    public Image interactIcon; //Little hand to interact with objects

    public bool isInteracting;

    void Start()
    {
        if (interactIcon != null)
        {
            interactIcon.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        //Shooting a ray
        if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            //Checks if we're not interacting
            if (!isInteracting)
            {
                if (interactIcon != null)
                {
                    interactIcon.enabled = true;
                }
                //Pressing interaction button
                if (Input.GetButtonDown(interactButton))
                {
                    //If we're getting a door
                    if (Input.GetKey(KeyCode.E))
                    {
                        //Magic happens
                        hit.collider.GetComponent<OpenFront>().ChangeDoorState();
                    }
                }
            }
        }
    }
}
