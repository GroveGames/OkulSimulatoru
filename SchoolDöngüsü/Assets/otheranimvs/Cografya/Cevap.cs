using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Cevap : MonoBehaviour
{
    public GameObject Dersegirpanel;
    public GameObject S�nav;

    public GameObject sonrakisoruyuaktif;
    public GameObject �ncekisoru;
    public yonetim yonetimA;
    public GameObject dersigectinpanel;

    public GameObject dersigecemedinpanel;

    public GameObject karakter;
    public GameObject DersKamera;
    public GameObject KarakterKamera;

    public yonetim S�re;
    public GameObject yonetim;

    public void sonrakisoruaktife()
    {

        Debug.Log("Alfonso ab");
        yonetimA.score += 1;

        sonrakisoruyuaktif.SetActive(true);
        �ncekisoru.SetActive(false);


    }

    public void finishcevap()
    {

        if (yonetimA.score > 3)
        {
            S�nav.SetActive(false);
            �ncekisoru.SetActive(false);
            dersigectinpanel.SetActive(true);
            Dersegirpanel.SetActive(false);
            S�re.toplam_saniye = 9999999;

            Time.timeScale = 1f;
        }
        else
        {
            S�nav.SetActive(false);
            �ncekisoru.SetActive(false);
            dersigecemedinpanel.SetActive(true);
            S�re.toplam_saniye = 9999999;
            Time.timeScale = 1f;
        }
    }


    public void finishcevapsonolmayan()
    {

        if (yonetimA.score > 3)
        {
            S�nav.SetActive(false);
            �ncekisoru.SetActive(false);
            dersigectinpanel.SetActive(true);
            Dersegirpanel.SetActive(false);
            S�re.toplam_saniye = 9999999;
            Time.timeScale = 1f;
        }
        else
        {
            S�nav.SetActive(false);
            �ncekisoru.SetActive(false);
            dersigecemedinpanel.SetActive(true);
            S�re.toplam_saniye = 9999999;
            Time.timeScale = 1f;
        }
    }




    public void hatalicevavp()
    {
        yonetimA.score -= 1;
    }


}