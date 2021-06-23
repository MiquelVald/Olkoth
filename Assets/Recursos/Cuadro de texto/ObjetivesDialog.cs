using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjetivesDialog : MonoBehaviour
{

    public string textValue;
    public string textValue2;
    public GameObject panel;
    public Text textElement;
    public ObtenerCandil txt2;
    Coroutine auxCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        auxCoroutine = StartCoroutine(Objetivo1());
    }

    // Update is called once per frame
    void Update()
    {
        if (txt2.C == true)
        {   
            textElement.text = "";
            textValue = textValue2;
            auxCoroutine = StartCoroutine(Objetivo2());
            txt2.C = false;
        }
    }

    IEnumerator Objetivo1()
    { 
        foreach (char caracter in textValue)
        {
            textElement.text = textElement.text + caracter;
            yield return new WaitForSeconds(0.05f);
        }

    }

    IEnumerator Objetivo2()
    {
        auxCoroutine = StartCoroutine(Objetivo1());
        yield return new WaitForEndOfFrame();
    }
}
