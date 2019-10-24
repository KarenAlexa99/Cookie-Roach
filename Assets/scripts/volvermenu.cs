using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volvermenu : MonoBehaviour
{
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

  
    

    public void CambiarEscena()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("Nivel 2", LoadSceneMode.Single);
    }
}
