using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponCollect : MonoBehaviour {

    public GameObject weaponText;
    public GameObject weaponButton;
    public int weaponsToCollect;

    public void WeaponCollected()
    {
        weaponsToCollect--;
        if (weaponsToCollect <= 0)
        {
            Debug.Log("Weapons collected");
            weaponText.SetActive(true);
            weaponButton.SetActive(true);
            //GameObject weaponUI = GameObject.Find("WeaponButton");
            //weaponUI.GetComponent<Button>().interactable = true;

        }
    }
}
