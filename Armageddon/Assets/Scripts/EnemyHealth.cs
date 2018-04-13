using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int Health = 100;

    void ApplyDamage()
    {
        GameObject Arms = GameObject.Find("Arms");
        controls playerScript = Arms.GetComponent<controls>();
       // MeleeSystem playerScript = Melee.GetComponent<MeleeSystem>();
        Health -= playerScript.TheDamage;

        if (Health <= 0)
        {
            Dead();
        }
    }

    void Dead()
    {
        Destroy(gameObject);
    }
}

