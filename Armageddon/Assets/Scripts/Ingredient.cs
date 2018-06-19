using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public LevelManager levelManager;
    public Transform respawnTransform;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            FindObjectOfType<AudioManager>().Play("Collect");
            respawnTransform.position = transform.position;
            levelManager.IngredientCollected();
            Destroy(this.gameObject);
        }
    }
}
