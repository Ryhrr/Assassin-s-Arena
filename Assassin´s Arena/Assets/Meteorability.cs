using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meteorability : MonoBehaviour
{

    public Text Meteorz�hler;
    private int z�hler = 0;
    void Start()
    {
        Meteorz�hler.text = Shop_System.MeteorCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (z�hler != 1)
        {
            if (Input.GetKeyUp(KeyCode.T))
            {
                z�hler = z�hler + 1;
                if (Shop_System.MeteorCount >= 1)
                {

                    Shop_System.MeteorCount = Shop_System.MeteorCount - 1;
                    Meteorz�hler.text = Shop_System.MeteorCount.ToString();

                }
            }
        }
    }
}

