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
   

    void Start()
    {
        pausemenu.SetActive(false);
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
                ResumeGame();
            }
            else
            {
                healthbar.SetActive(false);
                PauseGame();
            }


        }
    }

    public void PauseGame()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }

    public void ResumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        healthbar.SetActive(true);
        ispaused = false;
    }

    public void Gotomain()
    {
        Time.timeScale = 1f;
        pausemenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
