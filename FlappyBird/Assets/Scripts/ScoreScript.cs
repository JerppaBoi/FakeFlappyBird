using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;

    [SerializeField] private Text currentScore;

    private int score;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        currentScore.text = "Score: " + score.ToString();
    }

    public void UpdateScore()
    {
        score++;
        currentScore.text = "Score: " + score.ToString();
    }

}
