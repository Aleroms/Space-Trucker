using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public SettingsMenu settingsMenu;

    public void StartButtonClicked()
    {
        Debug.Log("Start Button Clicked");
        SceneManager.LoadScene(1);
        //TODO: Load Game Scene.
    }

    public void SettingsButtonClicked()
    {
        gameObject.SetActive(false);
        settingsMenu.ShowMenu();
    }

    public void ExitButtonClicked()
    {
        Application.Quit();
    }


    public void ShowMenu()
    {
        gameObject.SetActive(true);
    }

    public void HideMenu()
    {
        gameObject.SetActive(false);
    }
}
