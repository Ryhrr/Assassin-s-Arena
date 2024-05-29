using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Holder : MonoBehaviour
{
    public Transform transform;
    public Abilities abilitiy;
    public Animator animator;

    float cooldownTime;
    float activeTime;



    private void Start()
    {
        

       
    }


    enum AbilityState
    {
        ready,
        active,
        cooldown
    }

   

    AbilityState state = AbilityState.ready;

    public KeyCode key;


    private void Update()
    {

        if (!Pausemenu.ispaused)
        {
            switch (state)
            {

                case AbilityState.ready:

                    if (Input.GetKey(key))
                    {
                        abilitiy.Activate(gameObject);
                        state = AbilityState.active;
                        activeTime = abilitiy.activeTime;

                    }

                    break;
                case AbilityState.active:


                    if (activeTime > 0)
                    {
                        activeTime -= Time.deltaTime;
                    }
                    else
                    {
                        state = AbilityState.cooldown;
                        cooldownTime = abilitiy.cooldownTime;
                    }


                    break;
                case AbilityState.cooldown:

                    animator.SetBool("Key", false);


                    if (activeTime > 0)
                    {
                        activeTime -= Time.deltaTime;
                    }
                    else
                    {
                        state = AbilityState.ready;
                    }
                    break;
            }
        }


        


    }   

}
