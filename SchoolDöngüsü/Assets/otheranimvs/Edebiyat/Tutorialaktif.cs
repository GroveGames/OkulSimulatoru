using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorialaktif : MonoBehaviour
{
    public GameObject Edebiyats�nav;
    public GameObject Tutorial;

    public void TutorialPlay()
    {
        Edebiyats�nav.SetActive(true);
        Tutorial.SetActive(false);
    }
}
