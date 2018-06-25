using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {

	public GameObject zombie;
	public Transform spawn; //variable to define the spawn position

	//function to define collision
	void OnTriggerEnter(Collider col){

		//if the gameobject has the tag zombie
		if (col.tag == "Zombie") {
			
			zombie = col.transform.gameObject; //the object will be fetched from the heirarchy 

			zombie.transform.position = spawn.transform.position; //its position will be changed to the position of the spawn position

		    zombie.transform.rotation = spawn.transform.rotation; //its rotation will be changed to the spawn rotation

		}
	}
}
