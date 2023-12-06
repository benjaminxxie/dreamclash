using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashSpell : MonoBehaviour
{
    public float life = 3;

    public HealthController healthController;
    public int damage = 20;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    //destroys game object on collision (probably going to remove and replace with damage)
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
    }

    
}

