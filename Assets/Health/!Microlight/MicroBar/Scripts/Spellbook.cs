using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spellbook : MonoBehaviour
{
    public Transform spellSpawnpoint;
    public GameObject spellPrefab;
    public float spellSpeed = 50;
    
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) //Mouse0
        {
            var spell = Instantiate(spellPrefab, spellSpawnpoint.position, spellSpawnpoint.rotation);
            spell.GetComponent<Rigidbody>().velocity = spellSpawnpoint.forward * spellSpeed;
        }
    }
}
