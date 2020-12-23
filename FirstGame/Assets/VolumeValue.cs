using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeValue : MonoBehaviour
{

    public AudioMixerGroup MixerGroup;

    private void OnEnable()
    {
        Time.timeScale = 0;
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
    }

    public void ToggleMusic(bool enabled)
    {
        if (enabled){
          MixerGroup.audioMixer.SetFloat("DoorsMusic", 0);  
          MixerGroup.audioMixer.SetFloat("FlashlightsMusic", 0);
          MixerGroup.audioMixer.SetFloat("VolumeMusic", 0);  
        }
        else {
            MixerGroup.audioMixer.SetFloat("DoorsMusic", -80);
            MixerGroup.audioMixer.SetFloat("FlashlightsMusic", -80);
            MixerGroup.audioMixer.SetFloat("VolumeMusic", -80); 
        }
    }

    public void ChangeVolume (float volume)
    {
        MixerGroup.audioMixer.SetFloat("VolumeMusic", Mathf.Lerp(-80, 0, volume));

    }



    //private AudioSource audioSource;
    //private float musicVolume = 1f;


    // Start is called before the first frame update
   // void Start()
    //{
        //audioSource = GetComponent<AudioSource>();
    //}

    // Update is called once per frame
//    void Update()
    //{
        //audioSource.volume = musicVolume;
   // }

   // private void SetVolume(float vol)
   // {
    //    musicVolume = vol;
   // }
}
