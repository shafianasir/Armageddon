using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Respawn : MonoBehaviour {

    public bool playerIsDead = false;
    public Transform respawnTransform;
   // public PlayerStats playerStats;
    public GameObject MenuUI;
    

    /*  void OnGUI()
      {
          if (playerIsDead)
          {
              FirstPersonController fpc = GetComponent<FirstPersonController>();
              fpc.enabled = false;

              GameObject Zombie = GameObject.FindWithTag("Zombie");
              AdvancedAI enemyScript = Zombie.GetComponent<AdvancedAI>();
              enemyScript.enabled = false;
          }
      }
      */
    public void RespawnPlayer()
    {
        MenuUI.SetActive(false);
     //   playerStats.Lives--;

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