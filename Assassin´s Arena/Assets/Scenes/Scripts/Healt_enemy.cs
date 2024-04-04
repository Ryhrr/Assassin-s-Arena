using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healt_enemy : MonoBehaviour
{

    public BoxCollider2D BoxCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D = GetComponent<BoxCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != "Enemy")
        {
            gameObject.transform.parent = collision.gameObject.transform;
            GetComponent<CircleCollider2D>().enabled = false;

        }
        if (collision.tag == "Mage")
        {
            var healthComponent = collision.GetComponent<Health>();
            if (healthComponent != null)
            {
                healthComponent.Damage(1);
            }
        }
    }
}
