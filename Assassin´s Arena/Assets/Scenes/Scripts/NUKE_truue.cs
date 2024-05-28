using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NUKE_truue : MonoBehaviour
{
   
    public static bool nuuke = false;
    
    void Start()
    {
        StartCoroutine(WaitAndDisableNuuke());
        
    }

    IEnumerator WaitAndDisableNuuke()
    {
        nuuke = true;
        yield return new WaitForSeconds(2);
        nuuke = false;

    }
}


