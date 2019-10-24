using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public GameObject GameWinText;
    public static GameObject GameWinStatic;
    // Use this for initialization
    void Start()
    {
        win.GameWinStatic = GameWinText;
        win.GameWinStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void show()
    {
        win.GameWinStatic.gameObject.SetActive(true);
    }
    public static void hide()
    {
        win.GameWinStatic.gameObject.SetActive(false);
    }
}
