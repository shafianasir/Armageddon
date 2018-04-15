using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public int levelNo;
    public int itemsToCollect;
    public int zombiesLeft;

    //private static LevelManager instance;
    //public static LevelManager Instance
    //{
    //    get
    //    {
    //        if (instance == null)
    //            instance = FindObjectOfType<LevelManager>();
    //        return instance;
    //    }
    //}

    //private int levelNo;
    //public int LevelNO
    //{
    //    get { return levelNo; }
    //    set { levelNo = value; }
    //}

    public void ZombieKilled()
    {
        zombiesLeft--;
        if(zombiesLeft <= 0)
        {
            if (itemsToCollect <= 0)
                Debug.Log("Level Completed...");
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
                Debug.Log("Level Completed...");
            else
                Debug.Log("You need to kill " + zombiesLeft + " zombies.");
        }
    }
}
