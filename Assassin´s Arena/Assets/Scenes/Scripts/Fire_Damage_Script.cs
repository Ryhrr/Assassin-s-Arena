using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Fire_Damage_Script : MonoBehaviour
{

    public PolygonCollider2D Poly_Colly;
    public List<EnemyControll> Enem_Controlls = new List<EnemyControll>();
    public List<Enemy_Health> Enem_HPs = new List<Enemy_Health>();

    float Destroy_time = 10;
    bool bletouch = false;
    [SerializeField] int idmg = 5;
    float timer = 0;
    double attackTime = 1;
    [SerializeField] float f_dmg_Ticks_Max = 1;
    float f_dmg_Ticks = 0;

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
            Enemy_Health enemyHP = collision.gameObject.GetComponent<Enemy_Health>();
            if (enemyHP != null && !Enem_HPs.Contains(enemyHP))
            {
                Enem_HPs.Add(enemyHP);

            }

            bletouch = true;
        }
    }
}
