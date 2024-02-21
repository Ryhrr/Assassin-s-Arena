using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu]
public class FireRing : Abilities
{
    public float Range;

    
    public override void Activate(GameObject parent)
    {
        Animator animator = parent.GetComponent<Animator>();

        animator.SetFloat("Ability", 1);


        if (Input.GetKeyDown(KeyCode.Q))
        {
           
            animator.SetBool("Q", true);

            
        }
       
    }

}