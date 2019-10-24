using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float tiempo = 2;

	// Use this for initialization
	void Start () {

        Invoke("Die", tiempo);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Die()
    {
        Destroy(gameObject);
    }
}
