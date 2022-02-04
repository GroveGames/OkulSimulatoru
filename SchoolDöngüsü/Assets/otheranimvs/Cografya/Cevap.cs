using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Cevap : MonoBehaviour
{
    public GameObject Dersegirpanel;
    public GameObject Sýnav;

    public GameObject sonrakisoruyuaktif;
    public GameObject öncekisoru;
    public yonetim yonetimA;
    public GameObject dersigectinpanel;

    public GameObject dersigecemedinpanel;

    public GameObject karakter;
    public GameObject DersKamera;
    public GameObject KarakterKamera;

    public yonetim Süre;
    public GameObject yonetim;

    public void sonrakisoruaktife()
    {

        Debug.Log("Alfonso ab");
        yonetimA.score += 1;

        sonrakisoruyuaktif.SetActive(true);
        öncekisoru.SetActive(false);


    }

    public void finishcevap()
    {

        if (yonetimA.score > 3)
        {
            Sýnav.SetActive(false);
            öncekisoru.SetActive(false);
            dersigectinpanel.SetActive(true);
            Dersegirpanel.SetActive(false);
            Süre.toplam_saniye = 9999999;

            Time.timeScale = 1f;
        }
        else
        {
            Sýnav.SetActive(false);
            öncekisoru.SetActive(false);
            dersigecemedinpanel.SetActive(true);
            Süre.toplam_saniye = 9999999;
            Time.timeScale = 1f;
        }
    }


    public void finishcevapsonolmayan()
    {

        if (yonetimA.score > 3)
        {
            Sýnav.SetActive(false);
            öncekisoru.SetActive(false);
            dersigectinpanel.SetActive(true);
            Dersegirpanel.SetActive(false);
            Süre.toplam_saniye = 9999999;
            Time.timeScale = 1f;
        }
        else
        {
            Sýnav.SetActive(false);
            öncekisoru.SetActive(false);
            dersigecemedinpanel.SetActive(true);
            Süre.toplam_saniye = 9999999;
            Time.timeScale = 1f;
        }
    }




    public void hatalicevavp()
    {
        yonetimA.score -= 1;
    }


}