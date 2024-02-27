using JetBrains.Annotations;
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


            animator.SetBool("Key", true);
            animator.SetFloat("Ability", 1);

        
       
    }

}