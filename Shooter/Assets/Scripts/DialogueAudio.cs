using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAudio : MonoBehaviour
{
    public AudioSource audioSource;
    
    public void Play()
    {
        audioSource.Play();
    }
    
}
