using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public Animator theAnimator;
    public int Health = 100;
    public LevelManager levelManager;

    void ApplyDamage()
    {
        GameObject Arms = GameObject.Find("Arms");
        controls playerScript = Arms.GetComponent<controls>();
       // MeleeSystem playerScript = Melee.GetComponent<MeleeSystem>();
        Health -= playerScript.TheDamage;

        if (Health <= 0)
        {
            theAnimator.SetBool("Die", true);
            Dead();
        }
    }

    void Dead()
    {
        levelManager.ZombieKilled();
        Destroy(gameObject);
        //or disable enemy script
    }
}

