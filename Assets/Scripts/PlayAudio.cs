using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    public void MakeAudio()
    {
        audioSource.PlayOneShot(clip, volume);
    }
}
