using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
public class OpenSafe : MonoBehaviour
{

    public Canvas safeCanvas;
    public GameObject playerObject;


    void Start()
    {
        safeCanvas.enabled = false;
    }
    public void ShowSafeCanvas()
    {
        safeCanvas.enabled = true;
        playerObject.GetComponent<FirstPersonController>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
