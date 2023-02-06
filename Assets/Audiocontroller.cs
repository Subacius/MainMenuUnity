using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audiocontroller : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    private void Start()
    {
        volumeSlider.value = audioSource.volume;
        volumeSlider.onValueChanged.AddListener(delegate { SetVolume(); });
    }

    public void SetVolume()
    {
        audioSource.volume = volumeSlider.value;
        Debug.Log("aa");
    }
}
