using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public  TMPro.TMP_Dropdown stimCategoryDrop;
    public  Slider speedSlider;
    private float sliderValue;
    public void PlayMode()
    {
        SceneManager.LoadScene("MainPlay");
        PlayerPrefs.SetFloat("Speed", speedSlider.value);

        if (stimCategoryDrop.value == 0)
        {
            PlayerPrefs.SetString("SelectedCategory", "Animals");
            PlayerPrefs.SetString("NotSelectedCategory", "Fruits");

        }
        else if (stimCategoryDrop.value == 1)
        {
            PlayerPrefs.SetString("SelectedCategory", "Fruits");
            PlayerPrefs.SetString("NotSelectedCategory", "Animals");
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
     public void OnSliderChange( float value)
    {
        sliderValue = value;
    }
}



