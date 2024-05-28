using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meteorability : MonoBehaviour
{

    public Text Meteorzähler;

    void Start()
    {
        Meteorzähler.text = Shop_System.MeteorCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            Shop_System.MeteorCount = Shop_System.MeteorCount - 1;
            Meteorzähler.text = Shop_System.MeteorCount.ToString();
        }
    }
}

