using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {

    public void SaveData(string level)
    {
        if (level == "1")
        {
            Debug.Log("Saving..." + level);
            PlayerPrefs.SetString("L1", "completed");
        }
        if (level == "2")
        {
            Debug.Log("Saving..." + level);
            PlayerPrefs.SetString("L2", "completed");
        }
        if (level == "3")
        {
            Debug.Log("Saving..." + level);
            PlayerPrefs.SetString("L3", "completed");
        }
        if (level == "4")
        {
            Debug.Log("Saving..." + level);
            PlayerPrefs.SetString("L4", "completed");
        }
        if (level == "5")
        {
            Debug.Log("Saving..." + level);
            PlayerPrefs.SetString("L5", "completed");
        }
        //PlayerPrefs.SetInt("Level", levelManager.levelNo);
    }
}