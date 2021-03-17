using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour  
{
    public AudioMixer audioMixer;  //控制Mixer變量
    private bool isPlayMusic;  //是否播放背景音樂

    public void SetMasterVolume(float volume)  //控制主因量
    {
        audioMixer.SetFloat("MasterVolume", volume);  //MasterVolumes是Master暴露出的參數
     
    }

    public void SetMusicVolume(float volume)    //控制背景音樂
    {
        audioMixer.SetFloat("MusicVolume", volume);  //MusicVolume是Music暴露出的參數

    }


}
