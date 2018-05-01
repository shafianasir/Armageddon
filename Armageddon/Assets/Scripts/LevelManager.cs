﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public GameObject endLevelUI;
    public Save savegame;

    //public Text zombiesText;
    public int levelNo;
    public int itemsToCollect;
    public int zombiesLeft;

    private void Start()
	{
        Time.timeScale = 1f;
    }

    public void ZombieKilled()
    {
        zombiesLeft--;
	//	zombiesText.text = "Zombies Left: " + zombiesLeft;
        if(zombiesLeft <= 0)
        {
            if (itemsToCollect <= 0)
            {
                LevelCompleted();
            }
            else
                Debug.Log("You need to collect " + itemsToCollect + " ingredients.");
        }
    }

    public void IngredientCollected(string name)
    {
        itemsToCollect--;
        Debug.Log("You collected: " + name);
        if (itemsToCollect <= 0)
        {
            if (zombiesLeft <= 0)
            {
                LevelCompleted();
            } 
            else
                Debug.Log("You need to kill " + zombiesLeft + " zombies.");
        }
    }

    void LevelCompleted()
    {
        Debug.Log("Level Completed...");
        Scene scene = SceneManager.GetActiveScene();
        string l = scene.name;
        char last = l[l.Length - 1];
        String lvl = last.ToString();
        savegame.SaveData(lvl);

        endLevelUI.SetActive(true);
        GameObject.Find("Player").SetActive(false);
        //Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
/*
[Serializable]
public class Level
{
	public int totalZombies;
    public int totalItems;
    //	public string levelInfo;
}
*/