using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public GameObject endLevelUI;
    public Save savegame;
    public Text TextUI;
    //public Text Text1;

    public int levelNo;
    public int itemsToCollect;
    public int zombiesLeft;

    private void Start()
	{
        Time.timeScale = 1f;
        //GameObject.Find("InGamePanel").SetActive(true);
        //Text1.GetComponent.< Text > ().enabled = true;
        GameObject Text1 = GameObject.Find("info1");
        Text txt = Text1.GetComponent<Text>();
        txt.enabled = true;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TextUI.text = " ";
            GameObject Text1 = GameObject.Find("info1");
            Text txt = Text1.GetComponent<Text>();
            txt.enabled = false;
        }
    }

    public void ZombieKilled()
    {
        zombiesLeft--;

        if (zombiesLeft <= 0)
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
       // Debug.Log("You collected: " + name);
        TextUI.text = "Ingredients left = " + itemsToCollect;
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
        //Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}