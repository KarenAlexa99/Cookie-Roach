using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{


   
    public float recuperarvida = 10f;
    


    public float Vida

    {
        get { return _Vida; }
        set
        {
            _Vida = value;


        }
    }


    // Use this for initialization
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {




    }
    void OnTriggerEnter2D(Collider2D PowerUp)
    {
        if (PowerUp.gameObject.tag == "powerup")
        {
            if (Vida < 100)
            {
                soundmanager.PlaySound("powerupsound");

                Vida += recuperarvida;



                Destroy(PowerUp.gameObject);



            }

        }
    }
        
    

    [SerializeField]

    private float _Vida = 100.0f;
}

