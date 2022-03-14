using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField]
    private LoadScreen load;
    [SerializeField]
    private AudioClip[] audioClip;

    private AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.clip = audioClip[1];
        audiosource.Play();
    }

    private void Update()
    {
        if (load.ShopScene == true)
        {
            audiosource.clip = audioClip[1];
        }

        if(load.mainScene == true)
        {
            audiosource.clip = audioClip[0];
        }
    }


}
