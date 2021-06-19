using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Notes : MonoBehaviour
{
    public Image noteImage;

    public AudioClip pickupSound;
    public AudioClip putAwaySound;
    public AudioSource audioSource;

    public GameObject playerObject;

    void Start()
    {
        noteImage.enabled = false;    
    }

    public void ShowNoteImage()
    {
        noteImage.enabled = true;
        audioSource.PlayOneShot(pickupSound);
        playerObject.GetComponent<FirstPersonController>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    public void HideNoteImage()
    {
        noteImage.enabled = false;
        audioSource.PlayOneShot(putAwaySound);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            playerObject.GetComponent<FirstPersonController>().enabled = true;

            noteImage.enabled = false;
        }
    }
}
