using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    // Use this for initialization
    //	void Start () {
    //}

    public float Distance;
    public Transform Target;
    public float lookAtDistance = 25.0f;
    public float attackRange = 15.0f;
    public float moveSpeed = 5.0f;
    public float Damping = 6.0f; //rotation speed

    void Update()
    {
        Distance = Vector3.Distance(Target.position, transform.position);
        if(Distance < lookAtDistance)
        {
            lookAt();
        }

        if (Distance < attackRange)
        {
            attack();
        }
    }

    void lookAt()
    { 
        Quaternion rotation = Quaternion.LookRotation(Target.position - transform.position); 
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping); //rotates enemy
    }

    void attack()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
