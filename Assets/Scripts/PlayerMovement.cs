using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool jumping = false;
    public float velH = 2.0f;
    public float velV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public float Speed = 90.0f;
    public float rotationS = 1.0f;
    private Rigidbody Physics;
    public float jumpForce = 1.0f; 
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        InvokeRepeating("jumpsey", 2.0f, 2.5f);
        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * Speed);




        yaw += velH * Input.GetAxis("Mouse X");
        pitch -= velV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        //transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * rotationS, 0));

        if (Input.GetKeyDown(KeyCode.Space) && !jumping)
        {
            Jump();
        }
    }

    void Jump()
    {
        Physics.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
    }
}
