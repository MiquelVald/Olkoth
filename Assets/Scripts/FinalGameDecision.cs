using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalGameDecision : MonoBehaviour
{
    public static string textValue;
    public static string textValue2 = "This was how Shan was able to free himself from the final traffic he was destined to suffer. but his willpower was greater than the entity could believe. In this way, Shan returned to his family in order to fix what happened before and try to return to what he was before.";
    public static string textValue3 = "Hahahaha... thank you Shan, for allowing me to get out of this horrible dimension in which I was imprisoned for so many years. you may have a good willpower, but how stupid you are to believe that we would get out together with both our consciences from that prison.... hahaha.";

    int i = 0;
    public int var;
    public GameObject Objetive;
    public GameObject Objetive2;
    public GameObject Objetive3;
    public Text textElement;
    Coroutine auxCoroutine;

    IEnumerator Objetivo1()
    {
        foreach (char caracter in textValue)
        {
            textElement.text = textElement.text + caracter;
            yield return new WaitForSeconds(0.05f);
        }
            Objetive3.gameObject.SetActive(true);

    }

    IEnumerator Objetivo2()
    {
        auxCoroutine = StartCoroutine(Objetivo1());
        yield return new WaitForEndOfFrame();
    }

    public void btn1()
    {
        Objetive.gameObject.SetActive(false);
        Objetive2.gameObject.SetActive(false);
        textElement.text = "";
        textValue = textValue2;
        i++;
        auxCoroutine = StartCoroutine(Objetivo2());
    }

    public void btn2()
    {
        Objetive.gameObject.SetActive(false);
        Objetive2.gameObject.SetActive(false);
        textElement.text = "";
        textValue = textValue3;
        i++;
        auxCoroutine = StartCoroutine(Objetivo2());
    }

    public void btnFinal()
    {
        Application.Quit();
    }
}
