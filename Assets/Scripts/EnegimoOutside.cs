using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnegimoOutside : MonoBehaviour
{
    public static int countShed = 0;
    public GameObject objetoenemigo;
    //public GameObject objetoefecto;
    public GameObject objetocollider;

    // Start is called before the first frame update
    void Start()
    {
        objetoenemigo.gameObject.SetActive(false);
        //objetoefecto.gameObject.SetActive(false);
        objetocollider.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        //Acciones a realizar cuando se detecta una entrada al Trigger.
        if (c.tag == "Player")
        {
            countShed++;
        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            countShed++;

            if(countShed == 2)
            {
                objetoenemigo.gameObject.SetActive(true);
                //objetoefecto.gameObject.SetActive(true);
                objetocollider.gameObject.SetActive(false);

            }
        }
    }
}
