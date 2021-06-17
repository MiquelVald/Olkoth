using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenSafe : MonoBehaviour
{

    public Canvas safeCanvas;

    void Start()
    {
        safeCanvas.enabled = false;
    }
    public void ShowSafeCanvas()
    {
        safeCanvas.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
