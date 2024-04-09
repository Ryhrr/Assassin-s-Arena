using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healt_enemy : MonoBehaviour
{

    public CircleCollider2D CircleCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        CircleCollider2D = GetComponent<CircleCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.tag == "Player")
        {
            var healthComponent = collision.GetComponent<Health>();
            if (healthComponent != null)
            {
                healthComponent.Damage(1);
            }
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            var healthComponent = collision.GetComponent<Health>();
            if (healthComponent != null)
            {
                healthComponent.Damage(1);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
