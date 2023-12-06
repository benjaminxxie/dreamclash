using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spellbook : MonoBehaviour
{
    public Transform spellSpawnpoint;
    public GameObject spellPrefab;
    public float spellSpeed = 10;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Mouse0
        {
            var spell = Instantiate(spellPrefab, spellSpawnpoint.position, spellSpawnpoint.rotation);
            spell.GetComponent<Rigidbody>().velocity = spellSpawnpoint.forward * spellSpeed;
        }
    }
}
