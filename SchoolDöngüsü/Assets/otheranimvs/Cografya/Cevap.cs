using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cevap : MonoBehaviour
{
    public GameObject sonrakisoruyuaktif;
    public GameObject �ncekisoru;
    public yonetim yonetimA;
    public GameObject dersigectinpanel;

    public GameObject dersigecemedinpanel;

    public GameObject karakter;
    public GameObject oyunKamera;
    public GameObject anaKamera;
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
            �ncekisoru.SetActive(false);
            dersigectinpanel.SetActive(true);


            karakter.SetActive(true);
            anaKamera.SetActive(true);
            oyunKamera.SetActive(false);
        }
        else
        {
            �ncekisoru.SetActive(false);
            dersigecemedinpanel.SetActive(true);


        }
    }


    public void hatalicevavp()
    {
        yonetimA.score -= 1;
    }


    public void Start()
    {
        karakter.SetActive(true);
        anaKamera.SetActive(true);
        oyunKamera.SetActive(false);
    }
    }
