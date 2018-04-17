using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {

    public LevelManager levelManager;
    public PlayerStats playerStats;

    public void SavePosition()
    {
        PlayerPrefs.SetFloat("PlayerPosition", transform.position.x);
        PlayerPrefs.SetFloat("PlayerPosition", transform.position.y);
        PlayerPrefs.SetFloat("PlayerPosition", transform.position.z);
    }

    public void SaveData()
    {
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
        int health = PlayerPrefs.GetInt("Health");
        playerStats.Health = health;
        //int level = PlayerPrefs.GetInt("Level");
        //
        int zombies = PlayerPrefs.GetInt("ZombiesToKill");
        levelManager.zombiesLeft = zombies;
        int items = PlayerPrefs.GetInt("ItemsToCollect");
        levelManager.itemsToCollect = items;
    }
}