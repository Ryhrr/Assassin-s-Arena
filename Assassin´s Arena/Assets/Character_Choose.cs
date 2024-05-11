using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_Choose : MonoBehaviour
{

    public GameObject Red_Mage;
    public GameObject Green_Mage;
    public GameObject Blue_Mage;

    



   
    void Start()
    {
        LoadProgress();

        // Überprüfe, ob Magier bereits gekauft wurden und aktualisiere die UI entsprechend
        if (Shop_System.RedMageBought)
        {
            
            Red_Mage.SetActive(false);
        }
        if (Shop_System.GreenMageBought)
        {
            
            Green_Mage.SetActive(false);
        }
        if (Shop_System.BlueMageBought)
        {
           
            Blue_Mage.SetActive(false);
        }
    }

    
    void Update()
    {
        LoadProgress();

        // Überprüfe, ob Magier bereits gekauft wurden und aktualisiere die UI entsprechend
        if (!Shop_System.RedMageBought)
        {

            Red_Mage.SetActive(true);
        }
        if (!Shop_System.GreenMageBought)
        {

            Green_Mage.SetActive(true);
        }
        if (!Shop_System.BlueMageBought)
        {

            Blue_Mage.SetActive(true);
        }

    }

    

    void LoadProgress()
    {
        // Lade den Fortschritt
        // Hier werden die Daten automatisch geladen, wenn sie vorhanden sind
    }
}
