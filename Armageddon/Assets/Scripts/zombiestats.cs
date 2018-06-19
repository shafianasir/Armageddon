using UnityEngine;
using UnityEngine.UI;

public class ZombieStats : MonoBehaviour
{
	public Slider healthSlider;
	public int maxhealth;
	public EnemyHealth zombie;

	void Start()
	{
		healthSlider.maxValue = maxhealth;
		healthSlider.value = maxhealth;
	}
	void Update()
	{
		healthSlider.value = zombie.Health;
		/*    if (HealthSlider.value <= 0)
        {
            HealthSlider.value -= Time.deltaTime / healthfallright * 2;
        } */
	} 
}