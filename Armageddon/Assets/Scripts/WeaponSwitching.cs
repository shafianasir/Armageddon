using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{

    public int currentWeapon = 0;
    public int maxWeapons = 2;
    public Animator theAnimator;

    void Start()
    {
        SelectWeapon(0);
    }

    void Update()
    {/*
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
            SelectWeapon(currentWeapon);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && maxWeapons >= 1)
        {
            currentWeapon = 1;
            SelectWeapon(currentWeapon);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && maxWeapons >= 2)
        {
            currentWeapon = 2;
            SelectWeapon(currentWeapon);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && maxWeapons >= 3)
        {
            currentWeapon = 3;
            SelectWeapon(currentWeapon);
        }
        */
    }

    public void Switch()
    {
        if (currentWeapon + 1 <= maxWeapons)
        {
            currentWeapon++;
        }
        else
        {
            currentWeapon = 0;
        }
        SelectWeapon(currentWeapon);
    }

    void SelectWeapon(int index)
    {
        for (var i = 0; i < transform.childCount; i++)
        {
            if (i == index)
            {
                if (transform.GetChild(i).name == "Fists")
                {
                    theAnimator.SetBool("WeaponIsOn", false);
                }
                else
                {
                    theAnimator.SetBool("WeaponIsOn", true);
                }
                transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}