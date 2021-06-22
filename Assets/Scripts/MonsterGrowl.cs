using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterGrowl : MonoBehaviour
{
    public OpenSafe openSafe;
    public AudioSource audioGrowl;
    public AudioClip monsterGrowl;

    void Start()
    {
        audioGrowl = GetComponent<AudioSource>();
 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
