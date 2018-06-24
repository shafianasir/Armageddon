using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {
    
    public AudioSource music;

    public void SetVolume(float volume)
    {
        music.volume = volume;
        Debug.Log(volume);
    }
}
