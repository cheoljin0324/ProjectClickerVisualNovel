using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AudioLong : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioRed;
    [SerializeField]
    private Slider AudioScanslider;

    private void Start()
    {
        StartCoroutine(StartAudio());
    }
    
    IEnumerator StartAudio()
    {
        yield return new WaitForEndOfFrame();
        AudioScanslider.maxValue = audioRed.clip.length;
        AudioScanslider.value = 0;
    }

    private void Update()
    {
        AudioUpdate();
    }

    private void AudioUpdate()
    {
        AudioScanslider.value = audioRed.time;
    }
}
