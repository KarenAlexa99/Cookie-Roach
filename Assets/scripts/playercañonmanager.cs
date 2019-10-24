using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercañonmanager : MonoBehaviour
{
    public float maxHealth = 100f;
    public GameObject Explosion;
    float curHealth;
    

    public Image HealthBar;








    // Use this for initialization
    void Start()
    {


        curHealth = maxHealth;
        HealthBar.fillAmount = curHealth / maxHealth;
    }

   

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("bullet"))
        {
            curHealth -= 10;
            HealthBar.fillAmount = curHealth / maxHealth;
        }


        if (HealthBar.fillAmount <= 0.0)
        {
            over.show();
            win.hide();
        }

        if (HealthBar.fillAmount <= 0.0)

        {
            if (Explosion != null)
            {
                Instantiate(Explosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }

        }

    }

}
