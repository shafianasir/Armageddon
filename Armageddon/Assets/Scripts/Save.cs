using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {

    public LevelManager levelManager;
    public PlayerStats playerStats;
    public PauseMenu menu;

    public void SavePosition()
    {
        PlayerPrefs.SetFloat("PlayerPosition", transform.position.x);
        PlayerPrefs.SetFloat("PlayerPosition", transform.position.y);
        PlayerPrefs.SetFloat("PlayerPosition", transform.position.z);
    }

    public void SaveData()
    {
        Debug.Log("Saving...");
        PlayerPrefs.SetInt("Lives", playerStats.Lives);
        PlayerPrefs.SetInt("Health", playerStats.Health);
        PlayerPrefs.SetInt("Level", levelManager.levelNo);
        PlayerPrefs.SetInt("ZombiesToKill", levelManager.zombiesLeft);
        PlayerPrefs.SetInt("ItemsToCollect", levelManager.itemsToCollect);
    }

    public void LoadPosition()
    {
        float x = PlayerPrefs.GetFloat("PlayerPosition");
        float y = PlayerPrefs.GetFloat("PlayerPosition");
        float z = PlayerPrefs.GetFloat("PlayerPosition");
        transform.position = new Vector3(x,y,z);
    }

    public void LoadData()
    {
        menu.Resume();
        playerStats.Lives = PlayerPrefs.GetInt("Lives");
        playerStats.Health = PlayerPrefs.GetInt("Health");
        //int level = PlayerPrefs.GetInt("Level");
        levelManager.zombiesLeft = PlayerPrefs.GetInt("ZombiesToKill");
        levelManager.itemsToCollect = PlayerPrefs.GetInt("ItemsToCollect");
        Debug.Log("Loading...");
    }
}