using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDamage : MonoBehaviour
{
    public HealthController healthController;
    public int damage = 70;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Spell")
        {
            healthController.SlimeDamage(damage);
            Debug.Log("Slime Damaged");
        } 
    }
}