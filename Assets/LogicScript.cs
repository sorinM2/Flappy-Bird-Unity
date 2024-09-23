using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;
    public GameObject GameOverScreen;

    [ContextMenu("IncreaseScore")]
    public void AddScore(int scoreToAdd)
    {
        score+=scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void AddScore()
    {
        score ++;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}

