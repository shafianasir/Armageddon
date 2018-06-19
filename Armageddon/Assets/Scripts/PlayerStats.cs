using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PlayerStats : MonoBehaviour {

    public int Lives;
    public int MaxLives = 3;
    public int Health;
    public int MaxHealth = 100;

    public Respawn respawn;
    public GameObject RetryUI;
    public GameObject FailUI;

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
        Lives--;
        FirstPersonController fpc = GetComponent<FirstPersonController>();
        fpc.enabled = false;
        FindObjectOfType<AudioManager>().Play("Fail");

        GameObject Zombie = GameObject.FindWithTag("Zombie");
        AdvancedAI enemyScript = Zombie.GetComponent<AdvancedAI>();
        enemyScript.enabled = false;

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
            
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void RespawnStats()
    {
        Health = MaxHealth;
    }
}