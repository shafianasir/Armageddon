using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour {

	[SerializeField] private Image customimage;

	void OnTriggerEnter(Collider box){
		if (box.CompareTag ("Player")) {
			customimage.enabled = true;
		}
	}
	void OnTriggerExit(Collider box){
		if (box.CompareTag ("Player")) {
			customimage.enabled = false;
		}
	}
}
