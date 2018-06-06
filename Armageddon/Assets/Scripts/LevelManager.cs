using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public GameObject endLevelUI;
    public Save saveGame;
    public GameObject text;
    public Transform respawnTransform;

    public int levelNo;
    public int itemsToCollect;
    public int weaponsToCollect;
    public int zombiesLeft;

    private void Start()
	{
        Time.timeScale = 1f;
        respawnTransform.position = transform.position;
        text.SetActive(true);
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

    public void IngredientCollected()
    {
        itemsToCollect--;
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

    public void WeaponCollected()
    {
        weaponsToCollect--;
        if (weaponsToCollect <= 0)
        {
            Debug.Log("Weapons collected");
            //enable button
        }
    }

    void LevelCompleted()
    {
        Debug.Log("Level Completed...");
        Scene scene = SceneManager.GetActiveScene();
        string l = scene.name;
        char last = l[l.Length - 1];
        String lvl = last.ToString();
        saveGame.SaveData(lvl);

        endLevelUI.SetActive(true);
        Time.timeScale = 0f;
        GameObject canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}