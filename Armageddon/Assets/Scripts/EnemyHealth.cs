using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public Animator theAnimator;
    public LevelManager levelManager;
	public float Health = 100;

    void ApplyDamage()
    {
        GameObject Arms = GameObject.Find("Arms");
        Controls con = Arms.GetComponent<Controls>();
        Health -= con.TheDamage;

        if (Health <= 0)
        {
            theAnimator.SetBool("Die", true);
            Dead();
        }
    }


    void Dead()
    {
        levelManager.ZombieKilled();
    //    Audiomanager.Instance.Play("zombie");
        Destroy(gameObject);
        //or disable enemy script
    }
}

