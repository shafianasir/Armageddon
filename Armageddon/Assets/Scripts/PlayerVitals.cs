using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerVitals : MonoBehaviour 
{
	public Slider HealthSlider;
	public int maxhealth;
	public int healthfallright;

	void Start(){
		HealthSlider.maxValue = maxhealth;
		HealthSlider.value = maxhealth;
	}
	void Update(){
		if (HealthSlider.value <= 0) {
			HealthSlider.value -= Time.deltaTime / healthfallright* 2;
	}
}
