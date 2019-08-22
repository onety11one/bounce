using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] background;
    public GameObject gameOverPanel;
    public GameObject scoreIcon;
    public GameObject coinsIcon;
    public GameObject livesIcon;
    public Text scoreText;
    public Text livesText;
    public Text coinsText;
    public Text topScoreText;
    public Text gameOverScoreText;
    public float acceleration = 0.0025f;
    public static int coins;
    public int lives;
    int topScore;
    int score;
    int sessoinCoins;

    void Start()
    {        
        SetBackground(Color.white);
        coins = PlayerPrefs.GetInt("Coins");
        lives = 0;
        sessoinCoins = 0;
        Time.timeScale = 1;       
    }

    void Update()
    {
        Time.timeScale += acceleration * Time.deltaTime;
    }

    public void GainLife()
    {
        lives++;
        livesText.text = lives.ToString();
    }

    public void GainCoin()
    {
        sessoinCoins++;
        coinsText.text = sessoinCoins.ToString();
    }

    public void GainScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void LoseLife()
    {
        lives--;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        scoreIcon.SetActive(false);
        coinsIcon.SetActive(false);
        livesIcon.SetActive(false);
        coins += sessoinCoins;
        PlayerPrefs.SetInt("Coins", coins);

        if (PlayerPrefs.GetInt("HighScore") < score)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        topScoreText.text = "Top Score: " + PlayerPrefs.GetInt("HighScore");
        gameOverScoreText.text = "Game Over! \n Score: " + score.ToString() + "\n Coins: " + sessoinCoins.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SetBackground(Color color)
    {
        foreach (var bg in background)
        {
            bg.GetComponent<Renderer>().sharedMaterial.color = color;
        }
    }
}
