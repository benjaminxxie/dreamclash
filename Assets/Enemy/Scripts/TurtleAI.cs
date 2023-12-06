using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class TurtleAI : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    //Patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    //Animation
    private Animator animator;

    void Start()
    {
        player = GameObject.Find("Character").transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange)
        {
            Patroling();
            //Animation
            animator.SetBool("Patrol", true);
        }
        else
        {
            //Animation
            animator.SetBool("Patrol", false);
        }

        if (playerInSightRange && !playerInAttackRange)
        {
            ChasePlayer();
            //Animation
            animator.SetBool("Chase", true);
        }
        else
        {
            //Animation
            animator.SetBool("Chase", false);
        }

        if (playerInSightRange && playerInAttackRange)
        {
            AttackPlayer();
            //Animation
            animator.SetBool("Attack", true);
        }
        else
        {
            //Animation
            animator.SetBool("Attack", false);
        }
    }

    void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
        {
            agent.SetDestination(walkPoint);
        }

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if (distanceToWalkPoint.magnitude < 20f)
        {
            walkPointSet = false;
        }
    }

    void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, +walkPointRange);
        float randomX = Random.Range(-walkPointRange, +walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
        {
            walkPointSet = true;
        }
    }

    void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    void AttackPlayer()
    {
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            //Attack Code Goes Here
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    void ResetAttack()
    {
        alreadyAttacked = false;
    }
}