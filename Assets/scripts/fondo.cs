using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondo : MonoBehaviour {

    public float Speed = 1.5f;
    Vector2  FondoPos;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        MoveFondo();
    }


        void MoveFondo() 
            {
        FondoPos += new Vector2(Time.time * Speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = FondoPos;
        
	}
}
