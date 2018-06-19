﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Animator theAnimator;
    public int TheDamage = 25;
    public float Distance;
    public float MaxDistance = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            Hit();
            theAnimator.SetBool("Hit01", true);
            FindObjectOfType<AudioManager>().Play("Hit");
        }
        if (Input.GetKeyUp(KeyCode.RightAlt))
        {
            Hit();
            theAnimator.SetBool("Hit01", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            Hit();
            theAnimator.SetBool("Hit02", true);
            FindObjectOfType<AudioManager>().Play("Hit");
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            Hit();
            theAnimator.SetBool("Hit02", false);
        }
    }

    public void Hit()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            Distance = hit.distance;
            if (Distance < MaxDistance)
            {
                hit.transform.SendMessage("ApplyDamage", TheDamage, SendMessageOptions.DontRequireReceiver);
                //FindObjectOfType<AudioManager>().Play("Hit");
            }
        }

    }

}