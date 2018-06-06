using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingredientlist : MonoBehaviour {

	public GameObject IngredientText;


	void OnTriggerEnter(Collider box){
		if (box.CompareTag ("Player")) {
			IngredientText.SetActive(true);
			GameObject IngredintUI = GameObject.Find("IngredientList");
			IngredintUI.GetComponent<Button>().interactable = true;
		}
	}

}
