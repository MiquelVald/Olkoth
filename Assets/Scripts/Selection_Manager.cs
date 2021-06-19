using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Selection_Manager : MonoBehaviour
{
    public float rayLength = 6f;
    public LayerMask layerMask;

    public OpenFront openFront;
    public OpenHallLeft openHallLeft;
    public OpenHallRight openHallRight;

    public string interactButton;

    public Image interactIcon;
    public bool isInteracting = false;

    public OpenSafe openSafe;

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
            // Damos de alta un objeto de raycast
            RaycastHit hit;
            // Damos de alta un rayo que seguirá la posición del ratón
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Si el objeto interactivo se encuentra dentro del rango del rayo...
            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                //Si no estamos interactuando con nada, pos bye manita, caso contrario, actívala
                if (isInteracting == false)
                {
                    if (interactIcon != null)
                    {
                        interactIcon.enabled = true;
                    }
                }
            //Hacemos algo al presionar la tecla E
            if (Input.GetKeyDown(KeyCode.E) && hit.collider.CompareTag("Door"))
            {
                //TEST: Borrar al final
                Debug.Log(hit.collider.name);

                openFront.ChangeDoorState();

            }
            else if (Input.GetKeyDown(KeyCode.E) && hit.collider.CompareTag("DoorHall"))
            {
                openHallLeft.ChangeDoorLHallState();
                openHallRight.ChangeDoorRHallState();
            }
            else if (hit.collider.CompareTag("Safe")) 
                {
                    hit.collider.GetComponent<OpenSafe>().ShowSafeCanvas();
                }
            }
        
        else
        {
            interactIcon.enabled = false;
        }
    }
}
