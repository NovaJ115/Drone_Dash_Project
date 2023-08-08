using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    
    public bool isMuted;

    public GameObject theSlider;

    public void Start()
    {
        var sliderValue = theSlider.GetComponent<Slider>().value;
        SetLevel(sliderValue);
    }


    public void SetLevel(float sliderValue)
    {
        sliderValue = theSlider.GetComponent<Slider>().value;
        mixer.SetFloat("Volume", Mathf.Log10(sliderValue) * 20);
    }


    public void StopAudio()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }

}
