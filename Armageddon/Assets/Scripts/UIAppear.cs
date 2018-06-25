using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour {

	[SerializeField] private Image customimage; //ingredient image variable
    public GameObject ingredients; 
    public GameObject list;
    public GameObject zombies;
    public GameObject text;

	//this function defines collision when object enters trigger
    void OnTriggerEnter(Collider box){
		
		//if the object that collided with box has a Player tag
		if (box.CompareTag ("Player")) {
			customimage.enabled = true; //image appears on screen
		}
        ingredients.SetActive(true); //ingredients enable
        list.SetActive(true);        //ingredient list enables
        zombies.SetActive(true);     //zombies enable
		text.SetActive(true);        //ingredient button text enables
    }

	//defines collision when object has stopped touching the trigger
	void OnTriggerExit(Collider box){

		//if the object that collided has a player tag on moving away
		if (box.CompareTag ("Player")) {
			customimage.enabled = false; //the image disappears from the screen
		}
	}


}
