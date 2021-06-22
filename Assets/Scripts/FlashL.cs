using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashL : MonoBehaviour
{
    public Light Luz1;
    bool onPressed = false;
    bool valid = true;
 

    // Start is called before the first frame update
    void Start()
    {
        Luz1.enabled = false;
       
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
            if (Luz1.enabled == true)
            {
                Luz1.enabled = true;
                
            }
            else
            {
                Luz1.enabled = false;
                
            }

        }
        else
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Luz1.enabled = !Luz1.enabled;

                if (valid)
                {
                    valid = false;
                }
                else
                {
                    valid = true;
                }

            }
        }
    }
}
