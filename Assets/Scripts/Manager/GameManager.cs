using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int blocksLeft;

    //vida
    private int health;
    //puntaje
    private int score;
    private int scoreHigh;

    public int Score 
    {
        get => score;
        set
        {
            score = value;
            HUD.Instance.UpdateScore(score);
        }
    }

    public int ScoreHigh
    {
        get => scoreHigh;
        set
        {
            scoreHigh = value;
            if(score > scoreHigh)
                HUD.Instance.UpdateScoreHigh(scoreHigh);
        }
    }

    public int Health
    {
        get => health;
        private set
        {
            health = value;
            //HUD.Instance.UpdateHealth(health);
        }
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        blocksLeft = GameObject.FindGameObjectsWithTag("Block").Length;

        //inicializar
        Score = 0;
        Health = 3;
    }

    public void BlockDestroyed()
    {
        blocksLeft--;
        if (blocksLeft <= 0)
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReLoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
