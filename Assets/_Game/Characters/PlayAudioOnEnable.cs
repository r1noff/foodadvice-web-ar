using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnEnable : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    
    private void OnEnable()
    {
        source.Play();
    }
}
