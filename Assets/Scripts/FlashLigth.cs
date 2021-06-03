using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLigth : MonoBehaviour
{

    public Light Luz1;
    bool onPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && onPressed == false)
        {
            onPressed = true;
        }
        else
        {
            if (Input.GetKeyDown("space") && onPressed == true)
            {
                onPressed = false;
            }
        }

        if (onPressed)
        {
            if(Luz1.enabled == true)
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
            }
        }
    }
}
