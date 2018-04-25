using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {

    public LevelManager levelManager;
    public PlayerStats playerStats;
    public PauseMenu menu;

    public void SaveData()
    {
        Debug.Log("Saving...");
    //    PlayerPrefs.SetInt("Lives", playerStats.Lives);
    //    PlayerPrefs.SetInt("Health", playerStats.Health);
        PlayerPrefs.SetInt("Level", levelManager.levelNo);
    //    PlayerPrefs.SetInt("ZombiesToKill", levelManager.zombiesLeft);
    //    PlayerPrefs.SetInt("ItemsToCollect", levelManager.itemsToCollect);
    }

    public void LoadData()
    {
        menu.Resume();
     //   playerStats.Lives = PlayerPrefs.GetInt("Lives");
     //   playerStats.Health = PlayerPrefs.GetInt("Health");
     //   levelManager.zombiesLeft = PlayerPrefs.GetInt("ZombiesToKill");
     //   levelManager.itemsToCollect = PlayerPrefs.GetInt("ItemsToCollect");
        Debug.Log("Loading...");
    }
}