using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleDamage : MonoBehaviour
{
    public HealthController healthController;
    public int damage = 70;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Spell")
        {
            healthController.TurtleDamage(damage);
            Debug.Log("Turtle Damaged");
        } 
    }
}