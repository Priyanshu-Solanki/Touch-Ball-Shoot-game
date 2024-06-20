using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public GameObject winText;
    public GameObject restartButton;

    void Update()
    {
        
    }

    public void ScoreUp()
    {
        score++;
        if(score >= 4)
        {
            Win();
        }
    }

    public void Win()
    {
        winText.SetActive(true);
        restartButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
