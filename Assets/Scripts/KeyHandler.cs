using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHandler : MonoBehaviour
{
    public OpenLast openLast;
    public AudioClip pickingUp;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void UnlockDoor()
    {
        audioSource.PlayOneShot(pickingUp);
        openLast.isLocked = false;

        StartCoroutine("WaitForSelfDestruct");
    }

    IEnumerator WaitForSelfDestruct()
    {
        GameObject.Find("Key").transform.localScale = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(pickingUp.length);
        killObject();       
    }

    void killObject()
    {
        gameObject.SetActive(false);
    }

}
