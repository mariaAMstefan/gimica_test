using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void play_sound()
    {
        audio.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
