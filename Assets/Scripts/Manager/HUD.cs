using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreHighText;

    public static HUD Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateHealth(int health)
    {
        healthText.text = $"{health}";
    }
    
    public void UpdateScore(int score)
    {
        scoreText.text = $"{score}";
    }

    public void UpdateScoreHigh(int scoreHigh)
    {
        scoreHighText.text = $"{scoreHigh}";
    }



}
