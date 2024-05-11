using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pausemenu : MonoBehaviour
{
    public GameObject healthbar;
    public GameObject pausemenu;
    public static bool ispaused;
    public GameObject deactivatepanel1;
    public GameObject deactivatepanel2;
    public GameObject deactivatepanel3;
    public GameObject deactivatepanel4;
    public GameObject Killcounter;
   

    void Start()
    {
        ispaused = false;
        Killcounter.SetActive(true);
        healthbar.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (ispaused)
            {
                deactivatepanel1.SetActive(false);
                deactivatepanel2.SetActive(false);
                deactivatepanel3.SetActive(false);
                deactivatepanel4.SetActive(false);


                ResumeGame();
            }
            else
            {
                ispaused = true;
                PauseGame();
            }


        }
    }

    public void PauseGame()
    {
        Killcounter.SetActive(false);
        healthbar.SetActive(false);
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }

    public void ResumeGame()
    {
       
        Killcounter.SetActive(true);
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        healthbar.SetActive(true);
        ispaused = false;

    }

    public void Gotomain()
    {
        Shop_System.Currency = Shop_System.Currency + Enemy_Health.killchanger;
        Shop_System.Currency = Shop_System.Currency + 1000;
        Time.timeScale = 1f;
        pausemenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
