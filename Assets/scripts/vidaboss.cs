using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaboss : MonoBehaviour
{
    public float Dañobala = 8f;



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
    void OnTriggerEnter2D(Collider2D bala)
    {
        if (bala.gameObject.tag == "bullet")
        {
            Vida -= Dañobala;



            Destroy(bala.gameObject);





        }

    }

    [SerializeField]

    private float _Vida = 100.0f;
}
