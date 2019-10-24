using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private Rigidbody2D BODY;

	// Use this for initialization
	void Start () {

        BODY = GetComponent<Rigidbody2D>();
        BODY.AddForce(new Vector2(-25 * 3, 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
