using UnityEngine;
using UnityEngine.UI;

public class PlayerVitals : MonoBehaviour
{
    public Slider healthSlider;
    public int maxhealth;
    public int healthfallright;
    public PlayerStats player;

    void Start()
    {
        healthSlider.maxValue = maxhealth;
        healthSlider.value = maxhealth;
    }
    void Update()
    {
        healthSlider.value = player.Health;
    /*    if (HealthSlider.value <= 0)
        {
            HealthSlider.value -= Time.deltaTime / healthfallright * 2;
        } */
    } 
}