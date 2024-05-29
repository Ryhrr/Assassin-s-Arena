using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NUKE_truue : MonoBehaviour
{
   
    public static bool nuuke = false;
    public Animator animator;

    void Start()
    {
        StartCoroutine(WaitAndDisableNuuke());
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Shop_System.MeteorCount >= 1)
        {
            animator.SetBool("Nuke", true);
        }
        else
        {
            animator.SetBool("Nuke", false);
        }
    }

    IEnumerator WaitAndDisableNuuke()
    {
        if (Shop_System.MeteorCount >= 1)
        {

            nuuke = true;
            yield return new WaitForSeconds(0.5f);
            nuuke = false;

        }
    }
}


