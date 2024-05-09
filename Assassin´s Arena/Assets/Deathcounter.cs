using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deathcounter : MonoBehaviour
{
    public Text Killcounter;
    
    void Update()
    {
        Killcounter.text = Enemy_Health.killchanger.ToString();


    }
}
