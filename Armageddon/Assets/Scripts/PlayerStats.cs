using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerStats : MonoBehaviour {

    public int Lives;
    public int MaxLives = 3;
    public int MaxHealth = 100;
    public int Health;

    public GameObject MenuUI;

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
         //   Lives--;
            Dead();
        }
    }

    void Dead()
    {
        //     GameObject Player = GameObject.Find("Player");
        //   RespawnMenu menu = Player.GetComponent<RespawnMenu>();
        // menu.playerIsDead = true;

        FirstPersonController fpc = GetComponent<FirstPersonController>();
        fpc.enabled = false;
        GameObject Zombie = GameObject.FindWithTag("Zombie");
        AdvancedAI enemyScript = Zombie.GetComponent<AdvancedAI>();
        enemyScript.enabled = false;
        Debug.Log("Player died");

        if (Lives > 0)
        {
            MenuUI.SetActive(true);
        }
        else
            Debug.Log("You lost all lives! Restart Game");
            //Restart Game
    }

    void RespawnStats()
    {
        Health = MaxHealth;
    }
}