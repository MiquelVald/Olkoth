using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObtenerCandil : MonoBehaviour
{

    public GameObject objeto;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;
    public Light Luz1;
    public Light Luz2;
    public bool C = false;
    public bool CH = false;

    // Start is called before the first frame update
    void Start()
    {
        
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
            objeto.gameObject.SetActive(true);
            objeto2.gameObject.SetActive(true);
            objeto3.gameObject.SetActive(true);
            objeto4.gameObject.SetActive(false);
            Luz1.enabled = true;
            Luz2.enabled = true;
            C = true;
            CH = true;
        }
    }
}
