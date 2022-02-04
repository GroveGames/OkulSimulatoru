using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitapac : MonoBehaviour
{
    public GameObject kitap;
    public GameObject karakter;
    public GameObject Fotoo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kitaplarabak")
        {
            karakter.SetActive(false);
            kitap.SetActive(true);
        }

        if (other.gameObject.tag == "Foto")
        {
            karakter.SetActive(false);
            Fotoo.SetActive(true);
        }

    }
}
