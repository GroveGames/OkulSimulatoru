using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject pausemenu;
    public GameObject pauseaktif;

    public GameObject kitap;
    public GameObject kitapgir;
    public GameObject karakter;
    public void ResumeGame()
    {
        pauseaktif.SetActive(true);
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void PauseAktif()
    {
        pauseaktif.SetActive(false);
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Kitapkapa()
    {
        kitapgir.SetActive(false);
        karakter.SetActive(true);
        kitap.SetActive(false);
    }

}
