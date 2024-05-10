using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Ability_WAIT : MonoBehaviour
{

    private Abiltiy_DMG abiltiy_DMG;
    public Animator animator;

    private void Start()
    {
       abiltiy_DMG = FindAnyObjectByType <Abiltiy_DMG>();
       animator = GetComponent<Animator>();
    }


    void Update()
    {
        
        if(abiltiy_DMG.ble_Ice_Aktive == true)
        {
            
        }


    }
}
