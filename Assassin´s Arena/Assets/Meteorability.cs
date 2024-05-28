using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meteorability : MonoBehaviour
{

    public Text Meteorz�hler;

    void Start()
    {
        Meteorz�hler.text = Shop_System.MeteorCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            Shop_System.MeteorCount = Shop_System.MeteorCount - 1;
            Meteorz�hler.text = Shop_System.MeteorCount.ToString();
        }
    }
}

