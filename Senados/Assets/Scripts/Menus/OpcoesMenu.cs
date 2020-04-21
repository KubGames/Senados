using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OpcoesMenu : MonoBehaviour
{

    [SerializeField] private GameObject VolumeSlider;    
    [SerializeField] private AudioMixer masterMixer;
    public void Voltar(){

        GameObject.Find("Canvas/Menu").SetActive(true);
        GameObject.Find("Canvas/OpçõesMenu").SetActive(false);


    }

    public void MasterVolume(float MasterLvl){

        masterMixer.SetFloat("MasterVol", MasterLvl);

    }

    public void MusicVolume(float MusicLvl){
        masterMixer.SetFloat("MusicaVol", MusicLvl);
    }

    public void SfxVolume(float sfxLvl){
        masterMixer.SetFloat("sfxVol", sfxLvl);
    }



}
