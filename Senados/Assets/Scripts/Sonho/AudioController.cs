using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    private AudioSource wind;
    private AudioSource bell;
    private void OnEnable() {
        wind = GetComponent<AudioSource>();
        wind.Play();
        bell = GameObject.Find("SoundEffects/Bell").GetComponent<AudioSource>();
    }

    public void PlayBell(){
        bell.Play();
    }
    // Update is called once per frame
    void Update()
    {
    }
}
