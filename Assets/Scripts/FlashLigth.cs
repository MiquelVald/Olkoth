using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLigth : MonoBehaviour
{

    public Light Luz1;
    bool onPressed = false;
    bool valid = true;
    public GameObject objeto;

    // Start is called before the first frame update
    void Start()
    {
        objeto.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("tab") && onPressed == false)
        {
            onPressed = true;
        }
        else
        {
            if (Input.GetKeyDown("tab") && onPressed == true)
            {
                onPressed = false;
            }
        }

        if (onPressed)
        {
            if(Luz1.enabled == true)
            {
                Luz1.enabled = true;
                objeto.gameObject.SetActive(true);
            }
            else
            {
                Luz1.enabled = false;
                objeto.gameObject.SetActive(false);
            }
            
        }
        else
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Luz1.enabled = !Luz1.enabled;

                if (valid)
                {
                    objeto.gameObject.SetActive(false);
                    valid = false;
                }
                else
                {
                    objeto.gameObject.SetActive(true);
                    valid = true;
                }
                
            }
        }
    }
}
