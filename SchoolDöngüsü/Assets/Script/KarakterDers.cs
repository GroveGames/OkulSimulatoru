using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterDers : MonoBehaviour
{
    public GameObject karakter;
    public GameObject KarakterKamera;

    public GameObject CanvasCografya;
    public GameObject CografyaDersKamera;

    public GameObject CanvasEdebiyat;
    public GameObject EdebiyatDersKamera;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "CografyaDers")
        {
            CanvasCografya.SetActive(true);
            karakter.SetActive(false);
            CografyaDersKamera.SetActive(true);
            KarakterKamera.SetActive(false);
        }
        if (collision.gameObject.tag == "EdebiyatDers")
        {
            CanvasEdebiyat.SetActive(true);
            karakter.SetActive(false);
            EdebiyatDersKamera.SetActive(true);
            KarakterKamera.SetActive(false);
        }


    }
}
