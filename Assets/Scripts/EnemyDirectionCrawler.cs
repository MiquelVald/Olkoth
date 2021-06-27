using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDirectionCrawler : MonoBehaviour
{
    Transform player;
    UnityEngine.AI.NavMeshAgent nav;
    private Animator ani;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ani.SetBool("Ataque", true);
            nav.SetDestination(player.position);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ani.SetBool("Ataque", false);
            nav.SetDestination(player.position);
        }

    }
}
