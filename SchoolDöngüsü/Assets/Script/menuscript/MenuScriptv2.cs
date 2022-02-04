using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScriptv2 : MonoBehaviour
{
    public void GoLevelSelection()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelSelection");

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void resgame()
    {
        Time.timeScale = 1f;
        int simdiki_sahne = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(simdiki_sahne);
    }



}
