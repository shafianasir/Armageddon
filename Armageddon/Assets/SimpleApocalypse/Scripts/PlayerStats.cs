using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int Lives;
    public int MaxLives = 5;
    public int MaxHealth = 100;
    public int Health;

    private void Start()
    {
        Lives = MaxLives;
        Health = MaxHealth;
    }

    void ApplyDamage()
    {
        GameObject Enemy = GameObject.FindWithTag("Zombie");
        AdvancedAI enemyScript = Enemy.GetComponent<AdvancedAI>();
        Health -= enemyScript.TheDamage;

        if (Health <= 0)
        {
            Lives--;
            Dead();
        }
    }

    void Dead()
    {
        GameObject Player = GameObject.Find("Player");
        RespawnMenu menu = Player.GetComponent<RespawnMenu>();
        menu.playerIsDead = true;
        Debug.Log("Player died");
     //   menu.playerIsDead = true;

        if(Lives <= 0)
        {
            Debug.Log("You lost all lives! Restart Game");
            //Restart Game
        }
    }

    void RespawnStats()
    {
        Health = MaxHealth;
    }
}