using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScr : MonoBehaviour
{
    public GameObject start;
    public GameObject settings;
    public GameObject menu;
    public GameObject set_menu;


    public void play()
    {
        menu.SetActive(true);
        start.SetActive(false);
        settings.SetActive(false);
    }

    public void Set ()
    {
        set_menu.SetActive(true);
        start.SetActive(false);
        settings.SetActive(false);
    }
    public void play_close()
    {
        menu.SetActive(false);
        start.SetActive(true);
        settings.SetActive(true);
    }

    public void Set_close()
    {
        set_menu.SetActive(false);
        start.SetActive(true);
        settings.SetActive(true);
    }
}
