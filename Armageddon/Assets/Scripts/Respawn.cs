using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Respawn : MonoBehaviour {

    public bool playerIsDead = false;
    public Transform respawnTransform;
    public GameObject MenuUI;
     
    public void RespawnPlayer()
    {
        MenuUI.SetActive(false);
        Time.timeScale = 1f;

        transform.position = respawnTransform.position;
        transform.rotation = respawnTransform.rotation;
        gameObject.SendMessage("RespawnStats");
        
        FirstPersonController fpc = GetComponent<FirstPersonController>();
        fpc.enabled = true;
        playerIsDead = false;
        Debug.Log("Player has respawned");

        GameObject Zombie = GameObject.FindWithTag("Zombie");
        AdvancedAI enemyScript = Zombie.GetComponent<AdvancedAI>();
        enemyScript.enabled = true;
    }
}