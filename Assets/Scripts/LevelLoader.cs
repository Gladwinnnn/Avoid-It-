using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game Scene");
        Time.timeScale = 1;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Start Scene");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
