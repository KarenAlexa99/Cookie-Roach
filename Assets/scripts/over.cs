using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class over : MonoBehaviour {

    public GameObject GameOverText;
    public static GameObject GameOverStatic;
    
    // Use this for initialization
    void Start () {
        over.GameOverStatic = GameOverText;
        over.GameOverStatic.gameObject.SetActive(false);
       
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    public static void show()
    {
        over.GameOverStatic.gameObject.SetActive(true);

    }
    public static void hide()
    {
        over.GameOverStatic.gameObject.SetActive(false);
    }
}
