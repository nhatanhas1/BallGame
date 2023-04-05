using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIComponents : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScoreText(string score)
    {
        if(scoreText != null)
        {
            scoreText.text = score;
        }
        
    }

    public void GameOverPanel(bool status)
    {
        if(gameOverPanel != null)
        {
            gameOverPanel.SetActive(status);
        }
    }
}
