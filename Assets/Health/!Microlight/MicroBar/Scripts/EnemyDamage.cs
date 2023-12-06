using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public HealthController healthController;
    public int damage = 15;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            healthController.TakeDamage(damage);
            Debug.Log("damage taken");
        }
    }
}