using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdebiyatTutorai : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject sýnav;

    public void TutorialGec()
    {
        tutorial.SetActive(false);
        sýnav.SetActive(true);
    }
}
