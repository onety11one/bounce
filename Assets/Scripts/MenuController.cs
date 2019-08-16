using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Text topScoreText;
    public Text totalScoreText;

    void Start()
    {        
        topScoreText.text = "Top Score: " + PlayerPrefs.GetInt("HighScore");
        totalScoreText.text = "$ " + PlayerPrefs.GetInt("TotalScore");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ResetTopScore()
    {
        PlayerPrefs.DeleteAll();
        topScoreText.text = "Top Score: " + 0;
        totalScoreText.text = "$ 0";
    }    
}
