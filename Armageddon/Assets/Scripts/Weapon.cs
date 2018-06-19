using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public CollectWeapons collectWeapons;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            collectWeapons.WeaponCollected();
            Destroy(this.gameObject);
        }
    }
}
