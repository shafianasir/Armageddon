
using UnityEngine;

public class GunScript : MonoBehaviour {

	public float damage= 25f;
	public float range= 100f;

	public ParticleSystem flash;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightAlt)){

			Shoot();
		}
	}
	void Shoot(){
		flash.Play ();

		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit, range)) {

			Debug.Log (hit.transform.name);
			BossHealth target =	hit.transform.GetComponent<BossHealth>();
			if (target != null) {
				target.TakeDamagegun(damage);
			}
		}

	}
}