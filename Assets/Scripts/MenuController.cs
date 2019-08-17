using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Text topScoreText;
    public Text coinsText;

    void Start()
    {        
        topScoreText.text = "Top Score: " + PlayerPrefs.GetInt("HighScore");
        coinsText.text = "$ " + PlayerPrefs.GetInt("Coins");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ResetTopScore()
    {
        PlayerPrefs.DeleteAll();
        topScoreText.text = "Top Score: " + 0;
        coinsText.text = "$ 0";
    }    
}
