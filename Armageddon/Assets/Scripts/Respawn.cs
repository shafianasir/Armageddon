using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Respawn : MonoBehaviour {

    public bool playerIsDead = false;
    public Transform respawnTransform;
    public GameObject MenuUI;
    public PlayerStats player;
    public Text Lives; 

    public void RespawnPlayer()
    {
        int l = player.Lives;
        string str = l.ToString();
        Lives.text =str;

        MenuUI.SetActive(false);
        Time.timeScale = 1f;

        transform.position = respawnTransform.position;
        transform.rotation = respawnTransform.rotation;
        gameObject.SendMessage("RespawnStats");

        GameObject Zombie = GameObject.FindWithTag("Zombie");
        Animator Anim = Zombie.GetComponent<Animator>();
        Anim.SetBool("Hit", false);

        FirstPersonController fpc = GetComponent<FirstPersonController>();
        fpc.enabled = true;
        playerIsDead = false;
        Debug.Log("Player has respawned");

        GameObject ZombieAnim = GameObject.FindWithTag("Zombie");
        AdvancedAI enemyScript = ZombieAnim.GetComponent<AdvancedAI>();
        enemyScript.enabled = true;
    }
}