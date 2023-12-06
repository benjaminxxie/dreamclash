using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public HealthController healthController;
    public int damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            healthController.TakeDamage(damage);
        }

        // if(collision.gameObject.tag == "Slime")
        // {
        //     healthController.SlimeDamage(damage);
        //     Debug.Log("slime damaged");
        // }

        // if (collision.gameObject.tag == "Turtle")
        // {
        //     healthController.TurtleDamage(damage);
        //     Debug.Log("turtle damaged");
        // }

        // if (collision.gameObject.tag == "Spell")
        // {
        //     healthController.TurtleDamage(70);
        //     healthController.SlimeDamage(70);
        //     Debug.Log("both damaged");
        // }

        
    }
}