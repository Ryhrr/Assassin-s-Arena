using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayerData : MonoBehaviour
{
   
    // F�ge diese Methode hinzu und rufe sie nach Bedarf auf, um die PlayerPrefs-Daten zu l�schen
    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("PlayerPrefs gel�scht!");
    }
}
