using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void LoadOption()
    {
        SceneManager.LoadScene("Option Scene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
