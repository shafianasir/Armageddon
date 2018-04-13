using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switching : MonoBehaviour {

    public GameObject Weapon01;
    public GameObject Weapon02;

    // Update is called once per frame
    void Update () {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Swap();
        }
		
	}
    void Swap()
    {
        if(Weapon01.active==true)
        {
            Weapon01.SetActive(false);
            Weapon02.SetActive(true);
        }
        else
        {
            Weapon01.SetActive(true);
            Weapon02.SetActive(false);
        }
    }
}
