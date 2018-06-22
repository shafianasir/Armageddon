using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayMenu : MonoBehaviour {

    GameObject myButton;

    public void Cutscene()
    {
        SceneManager.LoadScene("Cutscene");
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
    }

    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("New Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}