using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class scr_VoiceOverTrigger : MonoBehaviour
{
    public string dialogueForClip; 
    public AudioClip voiceoverLine;

    private void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            
        }
    }

}
