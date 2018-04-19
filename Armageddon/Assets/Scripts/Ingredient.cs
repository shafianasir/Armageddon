using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public string myName;
    public LevelManager levelManager;

	void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            //LevelManager.Instance.IngredientCollected();
            levelManager.IngredientCollected(myName);
            Destroy(this.gameObject);
        }
    }
}
