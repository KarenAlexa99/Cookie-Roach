using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour {
    public AudioSource Coin01;
    // Use this for initialization
    void Start () {
        Coin01 = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "next")
        {
            Coin01.Play();
            SceneManager.LoadScene("boss1", LoadSceneMode.Single);
        }
    }
}
