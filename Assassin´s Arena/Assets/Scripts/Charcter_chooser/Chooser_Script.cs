using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAnimator : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Var_Creater.Mage_color == 1)
        {
            animator.SetInteger("Color", 1);
        }
        else if (Var_Creater.Mage_color == 2)
        {
            animator.SetInteger("Color", 2);
        }
        else if (Var_Creater.Mage_color == 3)
        {
            animator.SetInteger("Color", 3);
        }
        else if (Var_Creater.Mage_color == 4)
        {
            animator.SetInteger("Color", 4);
        }
        else
        {
            // Do nothing
        }
    }
}