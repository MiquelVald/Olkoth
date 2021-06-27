using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDirection : MonoBehaviour
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
        if(other.tag == "Player")
        {
           ani.SetBool("move_forward_fast", false);
           ani.SetBool("idle_normal", false);
           ani.SetBool("idle_combat", true);
           ani.SetBool("attack_short_001", true);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ani.SetBool("idle_normal", true);
            ani.SetBool("move_forward", true);
            ani.SetBool("idle_normal", false);
            ani.SetBool("move_forward", false);
            ani.SetBool("move_forward_fast", true);
            ani.SetBool("idle_combat", false);
            ani.SetBool("attack_short_001", false);
        }

    }
}
