using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public Animator anim;
    public NewBehaviourScript Behaviour;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
        Behaviour = GetComponent<NewBehaviourScript>();
    }   


    public void Damage(int amount)
    {

        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            //dead :(
            anim.SetBool("Dead", true);
            Behaviour.MoveSpeed = 0;

            
        }
    }
}
