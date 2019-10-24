using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
    public GameObject Panel;

	// Use this for initialization
	void Start () {

        Panel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AbrirPanel()
    {
        Panel.SetActive(true);
    }
    public void CerrarPanel()
    {
        Panel.SetActive(false);
    }


    public void CambiarEscena()
    {
        SceneManager.LoadScene("1COSA", LoadSceneMode.Single);
    }
    public void MostrarInstrucciones()
    {
        SceneManager.LoadScene("instrucciones", LoadSceneMode.Single);
    }
}
