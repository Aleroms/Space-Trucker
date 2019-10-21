using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public MainMenu mainMenu;

    public void ShowMenu()
    {
        gameObject.SetActive(true);
    }

    public void HideMenu()
    {
        gameObject.SetActive(false);
    }

    public void BackButtonClicked()
    {
        HideMenu();
        mainMenu.ShowMenu();
    }

}
