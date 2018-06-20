
using UnityEngine;

public class BossHealth : MonoBehaviour {

	public float health= 120f;
	public Animator theAnimator;
	public LevelManager levelManager;

	public void TakeDamagegun(float amount){

		health -= amount;
		if (health <= 0f) {
			Dead ();
		}
	}

	void Dead(){
		Destroy(gameObject);
	}
}
