using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Abiltiy_DMG : MonoBehaviour
{
    public PolygonCollider2D Poly_Colly;
    public List<EnemyControll> Enem_Controlls = new List<EnemyControll>();
    public List<Enemy_Health> Enem_HPs = new List<Enemy_Health>();

    bool bletouch = false;
    [SerializeField] float fslow = 2;
    [SerializeField] int idmg = 5;
    float timer = 0;
    double attackTime = 0.5;

    void Start()
    {
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
                foreach (Enemy_Health enemyHP in Enem_HPs)
                {
                    enemyHP.Damage_Enemy(idmg);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyControll enemyControll = collision.gameObject.GetComponent<EnemyControll>();
            if (enemyControll != null)
            {
                Enem_Controlls.Add(enemyControll);
                enemyControll.speed = fslow;
            }

            Enemy_Health enemyHP = collision.gameObject.GetComponent<Enemy_Health>();
            if (enemyHP != null)
            {
                Enem_HPs.Add(enemyHP);
            }

            bletouch = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyControll enemyControll = collision.gameObject.GetComponent<EnemyControll>();
            if (enemyControll != null && !Enem_Controlls.Contains(enemyControll))
            {
                Enem_Controlls.Add(enemyControll);
                enemyControll.speed = fslow;
            }

            Enemy_Health enemyHP = collision.gameObject.GetComponent<Enemy_Health>();
            if (enemyHP != null && !Enem_HPs.Contains(enemyHP))
            {
                Enem_HPs.Add(enemyHP);
            }

            bletouch = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyControll enemyControll = collision.gameObject.GetComponent<EnemyControll>();
            if (enemyControll != null)
            {
                Enem_Controlls.Remove(enemyControll);
                if (Enem_Controlls.Count == 0)
                {
                    bletouch = false;
                }
                else
                {
                    // Adjust speed to the first enemy left in the list
                    Enem_Controlls[0].speed = fslow;
                }
            }

            Enemy_Health enemyHP = collision.gameObject.GetComponent<Enemy_Health>();
            if (enemyHP != null)
            {
                Enem_HPs.Remove(enemyHP);
            }
        }
    }
}