using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {
    
   // public float hslider=0f;
    public AudioSource music;

    public void SetVolume(float volume)
    {
        music.volume = volume;
        Debug.Log(volume);
    }
}
