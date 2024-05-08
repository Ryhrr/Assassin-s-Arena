using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
    public Text valueText;
    [SerializeField] Slider volumeSlider;
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

    public void OnVolumeChange()
    {
        AudioListener.volume = volumeSlider.value; 
    
    }

    public void ResetToDefault()
    {
        volumeSlider.value = 100;
    }

}
