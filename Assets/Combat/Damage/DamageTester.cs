using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            playerAtm.DealDamage(enemyAtm.gameObject);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            enemyAtm.DealDamage(playerAtm.gameObject);
        }
    }
}