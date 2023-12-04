using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlay : MonoBehaviour
{
    public Slider volumeSlider;
    public GameObject ObjectMusic;
    private float MusicVolume = 1f;
    [SerializeField] private AudioSource AudioSource;

    public static MusicPlay instance;

    private void Awake() {
        if (instance == null) {
            instance = this;
            // ObjectMusic = GameObject.FindWithTag("BGM"); 
            AudioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject);
            AudioSource.Play();
            // DontDestroyOnLoad(AudioSource);
        } else {
            Destroy(gameObject);
        }
        
    }
    private void Start() {
        
        // MusicVolume = PlayerPrefs.GetFloat("volume");
        PlayerPrefs.SetFloat("volume", MusicVolume);
        AudioSource.volume = MusicVolume;
        // volumeSlider.value = MusicVolume;
    }

    private void Update() {
        MusicVolume = PlayerPrefs.GetFloat("volume"); 
        AudioSource.volume = MusicVolume;
        
    }

    public void VolumeUpdater(float volume) {
        PlayerPrefs.SetFloat("volume", volume);
    }
}
