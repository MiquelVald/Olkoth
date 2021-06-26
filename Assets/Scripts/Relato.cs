using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Relato : MonoBehaviour
{

    public static string textValue = "Shan Von Everic is a talented former writer of horror and suspense novels of late. The reason for his retirement was that his work as a writer was too time-consuming, so he spent much of his life immersed in the novels he created, neglecting his family...";
    public static string textValue2 = "For this reason, his wife constantly reproached him, so on one occasion, she takes their daughter and they disappear, not without first reproaching him to his face for all the carelessness he had over them, telling him that she didn't even feel being in a marriage with him anymore and this emptiness was only more present when they were together...";
    public static string textValue3 = "As the years went by, Shan searched for a way to recover his daughter and wife whom he had lost that unfortunate night. Of course, his search was unsuccessful and the more time passed, the more he assimilated that he would never see his family again, generating a horrible emptiness that ended up taking him away from his life as a writer and sinking into alcoholism night after night with his faithful bottle of Jack Daniels 1975 whiskey...";
    public static string textValue4 = "Upon waking up one morning, Shan received an email from his researcher friend Natalie Dreams, where she commented that she knew the address of the house where his wife and daughter were staying. Without thinking, Shan told Natalie the address of a possible meeting point with her, a bar that he frequented constantly: Amber, and there he waited several hours for their meeting, since he was urgently interested in the location of his family...";
    public static string textValue5 = "Natalie never arrived at that meeting, so Shan, disappointed, was about to leave the place, but when he passed by the dining room bar, he found a lady dressed in black that generated a particular interest in him since her face could not be seen at all. Shan approached with curiosity and asked about her and if she was well. She spoke to him for a few moments saying that her friend (Natalie) had left a letter for him with his wife's address...";
    public static string textValue6 = "Surprised and wary, Shan was speechless at the mysterious figure in front of him, however, dismayed at the state of his wife and daughter, he grabbed his things and ventured directly to the address marked on the letter. 'Anderson Valley Hills, you'll identify it when you see it' was all it contained, written in the exquisite typography that only his friend Natalia could have written....";
    public static string textValue7 = "What Shan found when he arrived at the site was nothing more than a two-story house, one of those old houses that surprise anyone who sees them since it seems that with a sneeze they would completely crumble...";
    public static string textValue8 = "Shan, without hesitation, enters the house and is surrounded by a darkness so dense that he could even feel it in his hands, the only thing he manages to glimpse was a small armchair in the center of the room with a small person in it: it was his daughter...";
    public static string textValue9 = "Dumbfounded, he approaches her slowly but the darkness begins to resent his shoulders, it becomes more and more complex for him to try to get closer to his girl, when he is about to reach the couch, the weight he carries on him just...falls...";
    public static string textValue10 = "Before she fades away, she can hear her daughter get up from the couch and move forward until she runs into something, the last thing she hears before she falls into a deep slumber is a thick voice saying: 'You are mine...you will be my conduit to the outside world.'";

    string[] Dialogs = new string[] { textValue, textValue2, textValue3, textValue4, textValue5, textValue6, textValue7, textValue8, textValue9, textValue10 };

    bool condi = false;
    int i = 0;
    public int var;
    //public GameObject Objetive;
    public Text textElement;
    Coroutine auxCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        auxCoroutine = StartCoroutine(Objetivo1());
    }

    // Update is called once per frame
    void Update()
    {
        if (condi == true && i <= 9)
        {
            textElement.text = "";
            textValue = Dialogs[i];
            auxCoroutine = StartCoroutine(Objetivo2());
            condi = false;
            //Objetive.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown("e") && var>i)
        {
            if(i == 9 && condi == false)
            {
                LevelLoader.LoadLevel("outside world");
            }

            if (condi == false && i <= 9)
            {
                condi = true;
                i++;
            }
            //Objetive.gameObject.SetActive(false);
        }
    }

    IEnumerator Objetivo1()
    {
        foreach (char caracter in textValue)
        {
            textElement.text = textElement.text + caracter;
            yield return new WaitForSeconds(0.05f);
        }
        var= i+1;

    }

    IEnumerator Objetivo2()
    {
        auxCoroutine = StartCoroutine(Objetivo1());
        yield return new WaitForEndOfFrame();
    }
}
