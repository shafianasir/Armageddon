public AudioClip zombieDeath;

private AudioSource BackGroundMusic;

private static Audiomanager instance;
public static Audiomanager Instance
{
	get
	{
		if (instance == null)
			instance = GameObject.FindObjectOfType<Audiomanager>();

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

	if (requiredName.Equals("zombie"))
		myAudioSource.PlayOneShot(zombieDeath);

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
}
