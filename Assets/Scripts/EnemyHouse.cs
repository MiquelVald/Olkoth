using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHouse : MonoBehaviour
{
    public static int countShed = 0;
    public GameObject objetoenemigo;
    

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
        
        
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            objetoenemigo.gameObject.SetActive(true);
        }
    }
}
