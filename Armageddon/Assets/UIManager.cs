using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {


	public void DisableBoolInAnimator(Animator anim)
	{
		anim.SetBool ("IsDisplayed", false);
	}
	public void EnableBoolInAnimator(Animator anim)
	{

		anim.SetBool ("IsDisplayed", true);
	}
	public void NavigateTo (int scene){
		Application.LoadLevel (scene);

	
	}
}
