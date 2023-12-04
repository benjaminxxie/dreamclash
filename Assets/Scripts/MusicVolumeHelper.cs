using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeHelper : MonoBehaviour
{
    Slider slider; 

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat("volume");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeUpdate(float volume) {
        PlayerPrefs.SetFloat("volume", volume);
    }
}
