using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottonsound : MonoBehaviour {

    public AudioClip Bottonsound;
    
    AudioSource fuenteAudio;
    // Use this for initialization
    void Start () {
        fuenteAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            fuenteAudio.clip = Bottonsound;
            fuenteAudio.Play();
        }


    }
}
