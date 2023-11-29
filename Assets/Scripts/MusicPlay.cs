using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlay : MonoBehaviour
{
    public Slider volumeSlider;
    public GameObject ObjectMusic;
    private float MusicVolume = 1f;
    private AudioSource AudioSource;

    private void Start() {
        ObjectMusic = GameObject.FindWithTag("BGM"); 
        AudioSource = ObjectMusic.GetComponent<AudioSource>();

        // MusicVolume = PlayerPrefs.GetFloat("volume");
        AudioSource.volume = MusicVolume;
        // volumeSlider.value = MusicVolume;
    }

    private void Update() {
        AudioSource.volume = MusicVolume;
        PlayerPrefs.SetFloat("volume", MusicVolume);
    }

    public void VolumeUpdater(float volume) {
        MusicVolume = volume;
    }

    // public void MusicReset() {
    //     PlayerPrefs.DeleteKey("volume");
    //     AudioSource.volume = 1;
    //     volumeSlider.value = 1;
    // }

    // public AudioSource AudioSource;

    // private void Start() {
    //     AudioSource.Play();
    // }

    // void Update() {
    //     AudioSource.volume = MusicVolume;
    // }

    // public void VolumeUpdater(float volume) {
    //     MusicVolume = volume;
    // }

    // public void MusicReset() {
    //     PlayerPrefs.DeleteKey("volume");
    //     AudioSource.volume = 1;
    //     volumeSlider.value = 1;
    // }
}
