using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class OpenSafe : MonoBehaviour
{

    public Canvas safeCanvas;
    public GameObject playerObject;
    public Text textNum_one;
    public Text textNum_two;
    public Text textNum_three;
    public AudioSource audioSource;
    public AudioClip monsterGrowl;


    private int num_1 = 0;
    private int num_2 = 0;
    private int num_3 = 0;



    public bool opened;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        safeCanvas.enabled = false;
        opened = false;
    }
    public void ShowSafeCanvas()
    {
        safeCanvas.enabled = true;
        playerObject.GetComponent<FirstPersonController>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void IncreaseNumber(int _number)
    {
        if (_number == 1)
        {

            num_1++;
            Debug.Log(num_1);
            textNum_one.text = num_1.ToString();
            if (num_1 > 9)
            {
                num_1 = 0;
                textNum_one.text = num_1.ToString();
            }
        }
        else if (_number == 2)
        {

            num_2++;
            Debug.Log(num_2);
            textNum_two.text = num_2.ToString();
            if (num_2 > 9)
            {
                num_2 = 0;
                textNum_two.text = num_2.ToString();
            }
        }
        else if (_number == 3)
        {

            num_3++;
            Debug.Log(num_3);
            textNum_three.text = num_3.ToString();
            if (num_3 > 9)
            {
                num_3 = 0;
                textNum_three.text = num_3.ToString();
            }
        }
    }

    public void DecreaseNumber(int _number)
    {
        if (_number == 1)
        {
            num_1--;
            textNum_one.text = num_1.ToString();
            if (num_1 < 0)
            {
                num_1 = 9;
                textNum_one.text = num_1.ToString();
            }
        }
        else if (_number == 2)
        {
            num_2--;
            textNum_two.text = num_2.ToString();
            if (num_2 < 0)
            {
                num_2 = 9;
                textNum_two.text = num_2.ToString();
            }
        }
        else if (_number == 3)
        {
            num_3--;
            textNum_three.text = num_3.ToString();
            if (num_3 < 0)
            {
                num_3 = 9;
                textNum_three.text = num_3.ToString();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            playerObject.GetComponent<FirstPersonController>().enabled = true;

            safeCanvas.enabled = false;
        }

        if (num_1 == 8 && num_2 == 4 && num_3 == 1)
        {
            opened = true;
        }

        if (opened)
        {
            UnlockSafe();
            gameObject.layer = 0;
        }
    }

    public void UnlockSafe()
    {

        Quaternion targetRotationOpenn = Quaternion.Euler(0, 0, 90f);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpenn, 2f * Time.deltaTime);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        playerObject.GetComponent<FirstPersonController>().enabled = true;

        safeCanvas.enabled = false;
    }

}
