using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class MenuController : MonoBehaviour
{
    public Text valueText;
    [SerializeField] Slider volumeSlider;
    public GameObject MutedImage;
    public GameObject UnmutedImage;



    public void SliderChanged()
    {
        if(volumeSlider.value <= 0)
        {
            MutedImage.SetActive(false);
            UnmutedImage.SetActive(true);
        }

        else
        {
            UnmutedImage.SetActive(false);
            MutedImage.SetActive(true);
        }

    }
    public void Mute()
    {
        AudioListener.volume = 0;
        volumeSlider.value = 0;
    }

    public void Unmute()
    {
        AudioListener.volume = 1;
        volumeSlider.value = 1;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Enemy_Health.killchanger = 0;
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
        volumeSlider.value = 1;
    }

}
