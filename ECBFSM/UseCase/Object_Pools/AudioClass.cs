using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioClass : MonoBehaviour
{

    [SerializeField]
    AudioSource audioSource;

    void Update(){
        if (!audioSource.isPlaying)
        {
            gameObject.SetActive(false);
        }
    }

    public void Play(AudioClip audio){
        this.audioSource.PlayOneShot(audio);
    }
}