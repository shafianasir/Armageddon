using UnityEngine.Audio;
using UnityEngine;
using System;

public class Audiomanager : MonoBehaviour {

	public sounds[] sound;
	// Use this for initialization
	void Awake () {
		foreach (sounds s in sound)
		{
			s.source =	gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;

			s.source.volume = s.volume;
				s.source.pitch = s.pitch;
		}
	}
	
	// Update is called once per frame
	public void Play(string name) {

		sounds s = Array.Find (sound, soundd => soundd.name == name);
		s.source.Play();
	}
}
