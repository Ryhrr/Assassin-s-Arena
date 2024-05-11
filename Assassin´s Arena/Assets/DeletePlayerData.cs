using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayerData : MonoBehaviour
{
   
    // Füge diese Methode hinzu und rufe sie nach Bedarf auf, um die PlayerPrefs-Daten zu löschen
    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("PlayerPrefs gelöscht!");
    }
}
