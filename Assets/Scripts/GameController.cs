using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{    
    public GameObject gameOverPanel;
    public Text scoreText;
    public Text livesText;
    public Text topScoreText;
    public Text coinsText;
    public Text gameOverScoreText;
    public float acceleration = 0.0025f;
    public int lives;
    public int topScore;
    public static int coins;
    int score;    

    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
        Time.timeScale = 1;        
        livesText.text = "Lives: " + lives.ToString();        
    }

    void Update()
    {
        Time.timeScale += acceleration * Time.deltaTime;
    }

    public void GainLife()
    {
        lives++;
        livesText.text = "Lives: " + lives.ToString();
    }

    public void GainCoin()
    {
        coins++;
        coinsText.text = "$: " + coins.ToString();
    }

    public void Scored()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();        
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);       
        PlayerPrefs.SetInt("Coins", coins);

        if(PlayerPrefs.GetInt("HighScore") < score)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        
        topScoreText.text = "Top Score: " + PlayerPrefs.GetInt("HighScore");
        gameOverScoreText.text = "Game Over! \n Score: " + score.ToString();        
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }    
}
