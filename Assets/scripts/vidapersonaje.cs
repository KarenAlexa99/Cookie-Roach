using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidapersonaje : MonoBehaviour {

    
    public float DañoDebuff = 20f;
    



    public float Vida

    {
        get { return _Vida; }
        set
        {
            _Vida = value;

          
        }
    }

   
    // Use this for initialization
    void Start() {

        
    }

    // Update is called once per frame
    void Update() {




    }
    void OnTriggerEnter2D(Collider2D Debuff)
    {
        if (Debuff.gameObject.tag == "Debuff")
        {
            soundmanager.PlaySound("debuffsound");
            Vida -= DañoDebuff;

            

            Destroy(Debuff.gameObject);


           


        }
      
    }

    [SerializeField]

    private float _Vida = 100.0f;
}
