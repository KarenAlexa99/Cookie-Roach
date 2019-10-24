using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Rigidbody2D bulletRB;
    public float bulletSpeed;

    void Awake()
    {
        bulletRB = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        bulletRB.velocity = new Vector2(bulletSpeed, bulletRB.velocity.y);
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
