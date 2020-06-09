using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour
{
    //configuration parameters
    [Range(0.1f, 10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int scorePerBlockDestroyed = 12;
    [SerializeField] Text scoreText;


    //state variables
    [SerializeField] int currentScore = 0;


    // Update is called once per frame


    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
     scoreText.text = currentScore.ToString();
    }

    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += scorePerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}


