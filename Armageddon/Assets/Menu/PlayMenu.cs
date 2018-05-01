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

    public void OnClicked(Button levelButton)
    {
        Debug.Log("Loading Level" + levelButton.name);
        SceneManager.LoadScene("Level" + levelButton.name);
    }

    public void LoadLevel()
    {
        myButton = GameObject.Find("1");
        myButton.GetComponent<Button>().interactable = true;

        if (PlayerPrefs.HasKey("L1"))
        {
            myButton = GameObject.Find("2");
            myButton.GetComponent<Button>().interactable = true;
        }
        if (PlayerPrefs.HasKey("L2"))
        {
            myButton = GameObject.Find("3");
            myButton.GetComponent<Button>().interactable = true;
        }
        if (PlayerPrefs.HasKey("L3"))
        {
            myButton = GameObject.Find("4");
            myButton.GetComponent<Button>().interactable = true;
        }
        if (PlayerPrefs.HasKey("L4"))
        {
            myButton = GameObject.Find("5");
            myButton.GetComponent<Button>().interactable = true;
        }

        /*
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
        */
    }
}