using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAdjus : MonoBehaviour
{
    [SerializeField]
    private AudioSource clickAudio;

    [SerializeField]
    private AudioSource MusicAudio;

    public void SetSoundClcik(float volum)
    {
        clickAudio.volume = volum;
    }

    public void SetSoundMusic(float volum)
    {
        MusicAudio.volume = volum;
    }

    private void Update()
    {
    }
}
