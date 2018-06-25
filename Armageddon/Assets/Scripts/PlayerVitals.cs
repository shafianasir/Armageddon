using UnityEngine;
using UnityEngine.UI;

public class PlayerVitals : MonoBehaviour
{
    public Slider healthSlider; //variable for health bar to acess the slider
    public int maxhealth; //variable to define max health of player
    public PlayerStats player; //variable of playerstats type to get information of player from that class

    void Start()
    {
        healthSlider.maxValue = maxhealth; //this will set the maxvalue of the slider to the maxhealth

        healthSlider.value = maxhealth; //start value also set to what the maxvalue will be
    }
    void Update()
    {
        healthSlider.value = player.Health; //value keeps updating with the decrease in the players health
    } 
}