using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour {

    int Level;

    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("Level"))
        {
            Level = PlayerPrefs.GetInt("Level");
            switch (Level)
            {
                case 1:
                    SceneManager.LoadScene("Level1");
                    Debug.Log("Loading Level 1");
                    break;
                case 2:
                    //  SceneManager.LoadScene("Level2");
                    Debug.Log("Loading Level 2");
                    break;
                default:
                    SceneManager.LoadScene("Level1");
                    break;
            }
        }
    }

    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("New Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}