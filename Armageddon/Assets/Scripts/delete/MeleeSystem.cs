using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeSystem : MonoBehaviour {

    public int TheDamage = 50;
    public float Distance;
    public float MaxDistance = 5f;
    public Animator Weapon;
 //   public Transform TheMace;

    void Start () {}

	void Update () {
        if(Input.GetButtonDown("Fire1"))
        {
          
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                Weapon.Play("Attack");
                Distance = hit.distance;
                if (Distance < MaxDistance)
                {
                    Debug.Log("Hitting: " + hit.transform.name);
                    hit.transform.SendMessage("ApplyDamage", TheDamage, SendMessageOptions.DontRequireReceiver);
                }
            }
        }  
  /*     if(TheMace.animation.isPlaying == false)
        {
            TheMace.animation.CrossFade("Idle");
        }
        if(Input.GetKey(KeyCode.LeftShift)
        {
            TheMace.animation.CrossFade("Running");
        } 
        if(Input.GetKeyUp(KeyCode.LeftShift)
        {
            TheMace.animation.CrossFade("Idle");
        }*/
	}
}
