using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectWeapons : MonoBehaviour {

    public LevelManager levelManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            levelManager.WeaponCollected();
            Destroy(this.gameObject);
        }
    }
}
