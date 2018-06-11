using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour {

	[SerializeField] private Image customimage;
    public GameObject ingredients;
    public GameObject list;
    public GameObject zombies;
    public GameObject text;

    void OnTriggerEnter(Collider box){
		if (box.CompareTag ("Player")) {
			customimage.enabled = true;
		}
        ingredients.SetActive(true);
        list.SetActive(true);
        zombies.SetActive(true);
        text.SetActive(true);
    }

	void OnTriggerExit(Collider box){
		if (box.CompareTag ("Player")) {
			customimage.enabled = false;
		}
	}


}
