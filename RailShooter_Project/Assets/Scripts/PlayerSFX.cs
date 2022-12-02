using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    AudioSource myAudio;

    public AudioClip[] sounds;

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    public void SoundPlay(int SoundNumber)
    {
        myAudio.clip = sounds[SoundNumber];

        myAudio.Play();

    }
}
