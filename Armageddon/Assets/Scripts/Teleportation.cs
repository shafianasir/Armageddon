using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {

	public GameObject zombie;
	public Transform spawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Zombie") {
			zombie = col.transform.gameObject;
			zombie.transform.position = spawn.transform.position;
		    zombie.transform.rotation = spawn.transform.rotation;
		}
	}
}
