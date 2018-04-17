
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class RespawnMenu : MonoBehaviour {

    public bool playerIsDead = false;
    public Transform respawnTransform;

    void OnGUI()
    {
        if (playerIsDead)
        {
            FirstPersonController fpc = GetComponent<FirstPersonController>();
            fpc.enabled = false;

            GameObject Zombie = GameObject.FindWithTag("Zombie");
            AdvancedAI enemyScript = Zombie.GetComponent<AdvancedAI>();
            enemyScript.enabled = false;

            if (GUI.Button(new Rect((float)(Screen.width * 0.5 - 50), (float)(Screen.height * 0.5 - 20), 100, 40), "Respawn"))
            {
                respawnPlayer();
            }
            if (GUI.Button(new Rect((float)(Screen.width * 0.5 - 50), (float)(Screen.height * 0.5 - 90), 100, 40), "Menu"))
            {
                Debug.Log("Return to Menu");
            }
        }
    }

    void respawnPlayer()
    {
        transform.position = respawnTransform.position;
        transform.rotation = respawnTransform.rotation;
        gameObject.SendMessage("RespawnStats");
        
        FirstPersonController fpc = GetComponent<FirstPersonController>();
        fpc.enabled = true;
        playerIsDead = false;
        Debug.Log("Player has respawned");

        GameObject Enemy = GameObject.Find("Enemy");
        AdvancedAI enemyScript = Enemy.GetComponent<AdvancedAI>();
        enemyScript.enabled = true;
    }
}