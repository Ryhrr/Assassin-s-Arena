using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public Animator anim;
    public EnemyControll controll;

    private int maxHealth = 50;
    [SerializeField]
    private int currentHealth;
    [SerializeField]

    void Start()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
        controll = GetComponent<EnemyControll>();
    }


    public void Damage_Enemy(int amount)
    {

        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            
            anim.SetBool("dead", true);
            controll.speed = 0;

            Destroy(gameObject,1);


        }
    }
}
