using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    Text recordDisplay;
    // int recordScore = 0;

    // void Start()
    // {
    //     recordDisplay = GetComponent<Text>();
    //     recordDisplay.text = GetInitialRecord().ToString();
        
    //     if (recordScore < PlayerPrefs.GetInt("Score"))
    //     {
    //         recordScore = PlayerPrefs.GetInt("Score");
    //         recordDisplay.text = recordScore.ToString();
    //     }
    // }

    void Start()
    {
        recordDisplay = GetComponent<Text>();
        recordDisplay.text = GetInitialRecord().ToString();
        if (PlayerPrefs.GetInt("Record") < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Record", PlayerPrefs.GetInt("Score"));
        }
        recordDisplay.text = PlayerPrefs.GetInt("Record").ToString();
    }

    int GetInitialRecord()
    {
        return 0;
    }
}