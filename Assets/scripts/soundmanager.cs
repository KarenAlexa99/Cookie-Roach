using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    public static AudioClip powerupsound, debuffsound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        powerupsound = Resources.Load<AudioClip> ("powerupsound");
        debuffsound = Resources.Load<AudioClip>("debuffsound");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "powerupsound":
                audioSrc.PlayOneShot(powerupsound);
                break;
            case "debuffsound":
                audioSrc.PlayOneShot(debuffsound);
                break;

        }
    }
}
