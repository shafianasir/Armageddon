using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    public int Lives;
    public int MaxLives = 3;
    public int MaxHealth = 100;
    public int Health;

    public GameObject RetryUI;
    public GameObject FailUI;
    public Text TextUI;

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
            Dead();
        }
    }

    void Dead()
    {
        //GameObject Player = GameObject.Find("Player");
        //RespawnMenu menu = Player.GetComponent<RespawnMenu>();
        //menu.playerIsDead = true;
        Lives--;
        TextUI.text = "Lives left = " + Lives;

        FirstPersonController fpc = GetComponent<FirstPersonController>();
        fpc.enabled = false;
        GameObject Zombie = GameObject.FindWithTag("Zombie");
        AdvancedAI enemyScript = Zombie.GetComponent<AdvancedAI>();
        enemyScript.enabled = false;
        Debug.Log("Player died");

        if (Lives > 0)
        {
            RetryUI.SetActive(true);
            Time.timeScale = 0f;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Debug.Log("You lost all lives! Restart Game");
            FailUI.SetActive(true);
            Time.timeScale = 0f;
            GameObject.Find("Player").SetActive(false);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            //Restart Game
        }
    }

    void RespawnStats()
    {
        Health = MaxHealth;
    }
}