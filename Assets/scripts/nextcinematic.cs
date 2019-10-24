using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextcinematic : MonoBehaviour
{
    public AudioSource Coin01;
    // Use this for initialization
    void Start()
    {
        Coin01 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Coin01.Play();
            SceneManager.LoadScene("cinematica1", LoadSceneMode.Single);
        }
    }
}

