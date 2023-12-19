using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target; // Referencia al Transform del personaje
    public NavMeshAgent navMeshAgent; // Referencia al NavMeshAgent del enemigo


    [Header("Stats Enemy")]
    public int health = 100;
    public int damage;
    public float moveSpeed = 5;

    private GameObject player;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
        navMeshAgent = GetComponent<NavMeshAgent>(); // Obtener el NavMeshAgent del enemigo

    }
    void Update()
    {
        if (target != null)
        {
            navMeshAgent.SetDestination(target.position); // Establecer la posición de destino como la del personaje
        }


        if (health <= 0)
        {
            Destroy(gameObject);
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerStats>().health -= damage;
        }
    }

}
