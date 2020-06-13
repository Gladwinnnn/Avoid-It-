using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    Text recordDisplay;
    int recordScore = 0;

    void Start()
    {
        recordDisplay = GetComponent<Text>();
        recordDisplay.text = GetInitialRecord().ToString();
        
        if (recordScore < PlayerPrefs.GetInt("Score"))
        {
            recordScore = PlayerPrefs.GetInt("Score");
            recordDisplay.text = recordScore.ToString();
        }
    }

    int GetInitialRecord()
    {
        return 0;
    }
}