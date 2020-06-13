using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] float waitToLoad = 1f;
    [SerializeField] GameObject winLabel;
    bool playerDead = false;

    void Start()
    {
        winLabel.SetActive(false);
    }

    void Update()
    {
        if (playerDead)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        yield return new WaitForSeconds(waitToLoad);
    }

    public void Finish()
    {
        playerDead = true;
        Time.timeScale = 0;
    }

    public bool PlayerDead()
    {
        if (playerDead) { return true; }
        else { return false; }
    }
}
