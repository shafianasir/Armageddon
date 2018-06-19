using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public WeaponCollect collectWeapons;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            FindObjectOfType<AudioManager>().Play("Collect");
            collectWeapons.WeaponCollected();
            Destroy(this.gameObject);
        }
    }
}
