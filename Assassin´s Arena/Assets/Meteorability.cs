using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meteorability : MonoBehaviour
{

    public Text Meteorzähler;
    private int zähler = 0;
    void Start()
    {
        Meteorzähler.text = Shop_System.MeteorCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (zähler != 1)
        {
            if (Input.GetKeyUp(KeyCode.T))
            {
                zähler = zähler + 1;
                if (Shop_System.MeteorCount >= 1)
                {

                    Shop_System.MeteorCount = Shop_System.MeteorCount - 1;
                    Meteorzähler.text = Shop_System.MeteorCount.ToString();

                }
            }
        }
    }
}

