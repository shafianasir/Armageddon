﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedAI : MonoBehaviour
{
    public Animator theAnimator;
    public CharacterController controller;
    public Transform Target;

    public float Distance;
    public float lookAtDistance = 25.0f;
    public float chaseRange = 15.0f;
    public float attackRange = 8.0f;
    public int attackRepeatTime = 1;
    private float attackTime;
    public float moveSpeed = 2.0f;
    public float Damping = 6.0f; //rotation speed
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    public int TheDamage = 20;

    void Start()
    {
        attackTime = Time.time;
    }

    void Update()
    {
        GameObject Player = GameObject.Find("Player");
        Respawn respawn = Player.GetComponent<Respawn>();
        if (respawn.playerIsDead == false)
        {
            Distance = Vector3.Distance(Target.position, transform.position);
            if (Distance < lookAtDistance)
            {
                LookAt();
            }

            if (Distance < attackRange)
            {
                Attack();
            }

            else if (Distance < chaseRange)
            {
                Chase();
            }
        }
    }

    void LookAt()
    {
        Quaternion rotation = Quaternion.LookRotation(Target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping); //rotates enemy
    }

    void Chase()
    {
        theAnimator.SetBool("Hit", false);
        theAnimator.SetBool("Move", true);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        moveDirection = transform.forward;
        moveDirection *= moveSpeed;

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void Attack()
    {
        if (Time.time > attackTime)
        {
            theAnimator.SetBool("Move", false);
            theAnimator.SetBool("Hit", true);
            Target.SendMessage("ApplyDamage", TheDamage, SendMessageOptions.DontRequireReceiver);
            Debug.Log("Enemy attacking");
            attackTime = Time.time + attackRepeatTime;
        }
    }

    void ApplyDamage()
    {
        chaseRange += 30f;
        moveSpeed += 2f;
        lookAtDistance += 40f;
    }
}