using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuOpen : MonoBehaviour
{
    public GameObject menuOpen;
    public GameObject mainMenu;
    public void menuToggle()
    {
        if (mainMenu.activeInHierarchy) {
            mainMenu.SetActive(false);
            menuOpen.SetActive(true);
        } else
        {
            mainMenu.SetActive(true);
            menuOpen.SetActive(false);
        }
    }
}
