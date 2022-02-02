using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class yonetim : MonoBehaviour
{
    public int score;
    public GameObject respanel;
    int toplam_saniye;
    public TextMeshProUGUI zaman;
    public TextMeshProUGUI skortext;
    void Start()
    {
        score = 0;
    }

    private void Awake()
    {
        Time.timeScale = 1.0f;

        toplam_saniye = 60;

        InvokeRepeating("saniye_azalt", 0.0f, 1.0f);
    }

    void saniye_azalt()
    {
        toplam_saniye--;
        zaman.text = toplam_saniye.ToString();

        if (toplam_saniye == 0)
        {
            respanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    void Update()
    {
        skortext.text = "Not : " + score.ToString();
    }
}
