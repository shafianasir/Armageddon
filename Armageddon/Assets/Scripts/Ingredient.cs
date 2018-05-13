using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public LevelManager levelManager;

	void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            levelManager.IngredientCollected();
            Destroy(this.gameObject);
        }
    }
}
