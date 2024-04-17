using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.U2D;

public class Abiltiy_DMG : MonoBehaviour
{
 
    public PolygonCollider2D Poly_Colly;
    public EnemyControll Enem_Controll;
    public Enemy_Health Enem_HP;

    bool bletouch = false;
    [SerializeField]
    float fslow = 2;
    [SerializeField]
    float fdmg = 5;
    float timer = 0;
    double attackTime = 0.5;


    void Start()
    {
        Enem_Controll = FindObjectOfType<EnemyControll>();
        Enem_HP = FindObjectOfType<Enemy_Health>();
        Poly_Colly = GetComponent<PolygonCollider2D>();
    }

    void Update()
    {
        if (bletouch)
        {
            timer += Time.deltaTime;
            if (timer >= attackTime)
            {
               timer = 0;
               Enem_HP.Damage_Enemy(5);
                
            }

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enem_Controll.speed = 2;
            bletouch = true;
        }

        collision.gameObject.GetComponent<Enemy_Health>();
        collision.gameObject.GetComponent<EnemyControll>();
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enem_Controll.speed = 2;
            bletouch = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy"))
        {
            Enem_Controll.speed = 5;
            bletouch = false;
        }

    }




}
