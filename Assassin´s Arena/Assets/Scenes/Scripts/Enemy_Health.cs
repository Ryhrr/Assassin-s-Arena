using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy_Health : MonoBehaviour
{
    public Animator anim;
    public EnemyControll controll;
    public static int killchanger = 0;
     public static int Kills_this_Round = 0;

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

    public IEnumerator WAIT()
    {
        yield return new WaitForSeconds(40f);
    }
    public void Damage_Enemy(int amount)
    {

        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            
            anim.SetBool("dead", true);
            controll.speed = 0;

            Destroy(gameObject,1);

            WAIT();
            
            killchanger = killchanger + 1;
<<<<<<< HEAD
         
=======
            Kills_this_Round = Kills_this_Round +1;

>>>>>>> 1b4ae6cdac167acf251fd882ffef0ee1809fe54c
        }
    }
}
