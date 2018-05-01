using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public GameObject endLevelUI;
    public Save savegame;
    Scene scene;

    //public Text zombiesText;
    public int levelNo;
    public int itemsToCollect;
    public int zombiesLeft;

    private void Start()
	{
     
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
        scene = SceneManager.GetActiveScene();
        Debug.Log("Level Completed...");
        Debug.Log(scene.name);
        string l = scene.name;
        char last = l[l.Length - 1];
        Debug.Log(last);
        String lvl = last.ToString();

        //levelNo++;
        savegame.SaveData(lvl);
        endLevelUI.SetActive(true);
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