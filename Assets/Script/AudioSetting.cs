using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSetting : MonoBehaviour
{
    public AudioSource Music;
    public AudioSource Sound;

    public Sprite MusicOn;
    public Sprite MusicOff;
    public Sprite SoundOn;
    public Sprite SoundOff;

    public Image MusicButton;
    public Image SoundButton;

    public void OnClicMusicOnOFF()
    {
        if(Music.volume >=0.1f)
        {
            Music.volume = 0;
            MusicButton.GetComponent<Image>().sprite = MusicOff;
        }
        else
        {
            Music.volume = 0.9f;
            MusicButton.GetComponent<Image>().sprite = MusicOn;
        }
    }
    public void OnClicSoundsOnOFF()
    {
        if (Sound.volume >= 0.1f)
        {
            Sound.volume = 0;
            SoundButton.GetComponent<Image>().sprite = SoundOff;
        }
        else
        {
            Sound.volume = 0.9f;
            SoundButton.GetComponent<Image>().sprite = SoundOn;
        }
    }
}