using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayMenu : MonoBehaviour {

    int Unlocked;
    int Level;

    GameObject myButton;

    public void LoadGame()
    {
        //EventSystem.current.currentSelectedGameObject.name();
        //Unlocked = PlayerPrefs.GetInt("Level");
        //SceneManager.LoadScene("Level" + Unlocked);
        //Debug.Log("Loading Level" + Unlocked);
    }

    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Starting New Game");
        //SceneManager.LoadScene("Level1");
    }

    public void OnClicked(Button level)
    {
        Debug.Log("Loading Level" + level.name);
        SceneManager.LoadScene("Level" + level.name);
    }

    public void LoadLevel()
    {
        if (PlayerPrefs.HasKey("Level"))
        {
            Unlocked = PlayerPrefs.GetInt("Level");
        }
        else
            Unlocked = 1;

        for(int i=Unlocked; i>0; i--)
        {
            Debug.Log(i);
            string str = i.ToString();
            myButton = GameObject.Find(str);
            myButton.GetComponent<Button>().interactable = true;
        }
    }
}