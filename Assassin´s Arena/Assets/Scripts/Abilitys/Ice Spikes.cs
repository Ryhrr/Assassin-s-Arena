using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IceSpikes : Abilities
{

    public float Range;


    public override void Activate(GameObject parent)
    {
        Animator animator = parent.GetComponent<Animator>();

        animator.SetFloat("Ability", 2);
        animator.SetBool("Key", true);


    }
}
