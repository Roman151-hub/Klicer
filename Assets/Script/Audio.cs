using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    private AudioSource _SoundConect;
    public AudioClip ClickSound;

    private void Start()
    {
        _SoundConect = GetComponent<AudioSource>();
    }

    public void StartSoundClick()
    {
        _SoundConect.PlayOneShot(ClickSound);   
    }
}
