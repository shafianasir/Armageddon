using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttoningpop : MonoBehaviour {
	[SerializeField] private Image customimage;

	

	public void OnClickButton() {
		
		customimage.enabled = true;
	}
}
