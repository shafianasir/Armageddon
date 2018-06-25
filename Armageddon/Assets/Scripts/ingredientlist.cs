using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingredientlist : MonoBehaviour {

	public GameObject IngredientText; //variable to activate the list of ingredients button

	//this function defines a collision 
	void OnTriggerEnter(Collider box){
		
		//if the object that collided with the box has player tag
		if (box.CompareTag ("Player")) {
			
			IngredientText.SetActive(true); //button activates

			GameObject IngredintUI = GameObject.Find("IngredientList"); //variable which finds the list image

			IngredintUI.GetComponent<Button>().interactable = true;//image appears when button clicked
		}
	}

}
