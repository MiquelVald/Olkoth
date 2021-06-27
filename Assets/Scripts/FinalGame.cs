using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalGame : MonoBehaviour
{
    public static string textValue = "Well Shan, it seems that I have misjudged you, you have a good mind control to not let you succumb to me. That way we could both get out of here and be free at last. But for that I need your help, you only need to allow me complete access to your mind to be able to free us from this evil world. What do you say? Do we have a deal?";
    
    

    int i = 0;
    public int var;
    public GameObject Objetive;
    public GameObject Objetive2;
    public Text textElement;
    Coroutine auxCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        i++;
        auxCoroutine = StartCoroutine(Objetivo1());
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    IEnumerator Objetivo1()
    {
        foreach (char caracter in textValue)
        {
            textElement.text = textElement.text + caracter;
            yield return new WaitForSeconds(0.05f);
        }
        if (i == 1)
        {
            Objetive.gameObject.SetActive(true);
            Objetive2.gameObject.SetActive(true);
        }

    }

    IEnumerator Objetivo2()
    {
        auxCoroutine = StartCoroutine(Objetivo1());
        yield return new WaitForEndOfFrame();
    }

}
