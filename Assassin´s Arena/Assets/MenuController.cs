using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
    public Text valueText;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitButton()
    {
        Application.Quit();
    }


    public void OnSliderChanged(float value)
    {
        valueText.text = value.ToString();
    }
}
