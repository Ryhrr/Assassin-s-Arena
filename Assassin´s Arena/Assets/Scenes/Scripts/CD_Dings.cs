using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CD_Dings : MonoBehaviour
{

    public Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetBool("Fire", true); 
        }
        else
        {
            anim.SetBool("Fire", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("Ice", true);
        }
        else
        {
            anim.SetBool("Ice", false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {

        }

        if (Input.GetKeyDown(KeyCode.T))
        {

        }



    }
}
