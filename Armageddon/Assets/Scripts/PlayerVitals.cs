using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerVitals : MonoBehaviour
{
    public Slider HealthSlider;
    public int maxhealth;
    public int healthfallright;
    public PlayerStats player;

    void Start()
    {
        HealthSlider.maxValue = maxhealth;
        HealthSlider.value = maxhealth;
    }
    void Update()
    {
        HealthSlider.value = player.Health;
        if (HealthSlider.value <= 0)
        {
            HealthSlider.value -= Time.deltaTime / healthfallright * 2;
        }
    }
}