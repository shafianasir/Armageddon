using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int MaxHealth = 100;
    public int Health;

    private void Start()
    {
        Health = MaxHealth;
    }

    void ApplyDamage()
    {
        GameObject Enemy = GameObject.FindWithTag("Zombie");
        AdvancedAI enemyScript = Enemy.GetComponent<AdvancedAI>();
        Health -= enemyScript.TheDamage;

        if (Health <= 0)
        {
            Dead();
        }
    }

    void Dead()
    {
     //   GameObject Player = GameObject.Find("Player");
     //   RespawnMenu menu = Player.GetComponent<RespawnMenu>();
     //   menu.playerIsDead = true;
        Debug.Log("Player died");
     //   menu.playerIsDead = true;
    }

    void RespawnStats()
    {
        Health = MaxHealth;
    }
}