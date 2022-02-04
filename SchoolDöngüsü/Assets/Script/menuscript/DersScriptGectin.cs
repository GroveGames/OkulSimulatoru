using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DersScriptGectin : MonoBehaviour
{
    public GameObject Gectinpanel;
    public GameObject gecemedinpanel;

    public GameObject karakter;
    public GameObject CografyaDersKamera;
    public GameObject KarakterKamera;

    public void Gectin()
    {
        Gectinpanel.SetActive(false);
        karakter.SetActive(true);
        CografyaDersKamera.SetActive(false);
        KarakterKamera.SetActive(true);
    }
}
