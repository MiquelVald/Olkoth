using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_house : MonoBehaviour
{

    Transform player;
    UnityEngine.AI.NavMeshAgent nav;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("ScreamerPainting").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }
}
