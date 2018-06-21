using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour {
    public Sound[] sounds;
    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Play("Theme");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
/*
public AudioClip zombieDeath;

	private AudioSource myAudioSource;

	private static AudioManager instance;
	public static AudioManager Instance
	{
		get
		{
			if (instance == null)
				instance = GameObject.FindObjectOfType<AudioManager>();

			return instance;
		}
	}

	public sounds[] sound;
	// Use this for initialization
	void Awake () {

		myAudioSource = this.GetComponent<AudioSource>();

		foreach (sounds s in sound)
		{
			s.source =	gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;

			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
		}
	}

	// Update is called once per frame
public void Play(string requiredName) {

		if (requiredName.Equals ("zombie"))
			myAudioSource.PlayOneShot (zombieDeath);
	}

		//Debug.Log("Inside Play function");
		//foreach(sounds s in sound)
		//{
		//    if (s.name.Equals(requiredName))
		//    {
		//        Debug.Log("Playing Required Sound");
		//        s.source.Play();
		//        break;
		//    }
		//}

		//sounds s = Array.Find (sound, requiredSound => requiredSound.name == name);
		//s.source.Play();
        */
	}