using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdebiyatTutorai : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject s�nav;

    public void TutorialGec()
    {
        tutorial.SetActive(false);
        s�nav.SetActive(true);
    }
}
