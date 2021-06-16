using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Desaparecer : MonoBehaviour
{

    public GameObject objeto;

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
        if (c.tag == "Enemigo")
        {
            objeto.gameObject.SetActive(false);
        }
    }
}
