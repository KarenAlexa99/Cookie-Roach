using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    public float moveSpeed = 50f;
    

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

       
       
        
            rb.velocity = Vector2.zero;
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

        
    }
    void OnTriggerEnter2D(Collider2D speed)
    {
        if (speed.tag == "speedpower")
        {
            soundmanager.PlaySound("powerupsound");
            Destroy(speed.gameObject);
            moveSpeed = 150f;
            StartCoroutine(Resetspeed());
        }

        if (speed.tag == "speeddebuff")
        {
            soundmanager.PlaySound("debuffsound");
            Destroy(speed.gameObject);
            moveSpeed = 20f;
            StartCoroutine(Resetspeed());

        }
    }
    private IEnumerator Resetspeed()
    {
        yield return new WaitForSeconds(5);
        moveSpeed = 50f;
    }
}

