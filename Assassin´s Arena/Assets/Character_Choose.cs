using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_Choose : MonoBehaviour
{

    public GameObject Red_Mage;
    public GameObject Green_Mage;
    public GameObject Blue_Mage;
    public GameObject Black_Mage;

    public GameObject DefaultMage;
    public GameObject Red_Mage_Spawner;
    public GameObject Green_Mage_Spawner;
    public GameObject Blue_Mage_Spawner;
    public GameObject Black_Mage_Spawner;



   
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
        if (Shop_System.BlackMageBought)
        {

            Black_Mage.SetActive(false);
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
        if (!Shop_System.BlackMageBought)
        {

            Black_Mage.SetActive(true);
        }

    }

    public void RedMageSpawner()
    {
        Red_Mage_Spawner.SetActive(true);
        DefaultMage.SetActive(false);
    }

    public void GreenMageSpawn()
    {
        Green_Mage_Spawner.SetActive(true);
        DefaultMage.SetActive(false);
    }

    public void BlueMageSpawn()
    {
        Blue_Mage_Spawner.SetActive(true);
        DefaultMage.SetActive(false);
    }
    public void BlackMageSpawner()
    {
        Black_Mage_Spawner.SetActive(true);
        DefaultMage.SetActive(false);
    }

    void LoadProgress()
    {
        // Lade den Fortschritt
        // Hier werden die Daten automatisch geladen, wenn sie vorhanden sind
    }
}
