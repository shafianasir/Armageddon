using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public GameObject text;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            text.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
