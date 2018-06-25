using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PlayerStats : MonoBehaviour {

    public int Lives; //lives controller
    public int MaxLives = 3; //no of maxlives of player
    public int Health; //health controller
    public int MaxHealth = 100; //count of maxhealth of player

    public Respawn respawn; //declare respawn position
    public GameObject RetryUI; //retry
    public GameObject FailUI; //fail

    private void Start() //function to declare Lives and Health equal to repective variables
    {
        Lives = MaxLives; 
        Health = MaxHealth;
    }

    void ApplyDamage() //function to retrieve damage to player
    {
        GameObject Enemy = GameObject.FindWithTag("Zombie"); //defines a variable which checks the tag of enemy

        AdvancedAI enemyScript = Enemy.GetComponent<AdvancedAI>(); //variable which retrieves enemy information from AdvancedAI

        Health -= enemyScript.TheDamage; //when hit by zombie health decreases according to the damage defined in enemy script

        if (Health <= 0) //when health falls to zero player dies
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