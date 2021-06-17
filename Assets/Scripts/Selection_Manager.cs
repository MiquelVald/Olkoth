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

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                if (isInteracting == false)
                {
                    if (interactIcon != null)
                    {
                        interactIcon.enabled = true;
                    }
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log(hit.collider.name);
                    openFront.ChangeDoorState();
                }else if (hit.collider.CompareTag("Safe"))
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
