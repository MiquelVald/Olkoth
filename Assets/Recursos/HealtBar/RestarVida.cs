using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestarVida : MonoBehaviour
{

    public VidaPlayer playerVida;

    public int cantidad;
    public float damageTime;
    float currentDamageTime;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            currentDamageTime += Time.deltaTime;

            if(currentDamageTime > damageTime)
            {
                playerVida.vida += cantidad;
                currentDamageTime = 0.0f;
            }
        }
    }
}
