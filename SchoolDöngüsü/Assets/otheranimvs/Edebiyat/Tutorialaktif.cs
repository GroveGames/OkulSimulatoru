using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorialaktif : MonoBehaviour
{
    public GameObject Edebiyatsýnav;
    public GameObject Tutorial;

    public void TutorialPlay()
    {
        Edebiyatsýnav.SetActive(true);
        Tutorial.SetActive(false);
    }
}
