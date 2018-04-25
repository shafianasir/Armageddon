using System;
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
        if (PlayerPrefs.HasKey("Level"))
        {
            savegame.LoadData();
        }
        // zombiesLeft = levels[currentLevel].totalZombies;
        //   itemsToCollect = levels[currentLevel].totalItems;
        //	zombiesText.text = "Zombies Left: " + zombiesLeft;
    }

    public void ZombieKilled()
    {
        zombiesLeft--;
	//	zombiesText.text = "Zombies Left: " + zombiesLeft;
        if(zombiesLeft <= 0)
        {
            if (itemsToCollect <= 0)
            {
                Debug.Log("Level Completed...");
                endLevelUI.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
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
                Debug.Log("Level Completed...");
                endLevelUI.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            } 
            else
                Debug.Log("You need to kill " + zombiesLeft + " zombies.");
        }
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