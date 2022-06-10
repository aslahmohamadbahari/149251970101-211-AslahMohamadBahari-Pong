using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ScoreManager : MonoBehaviour
{
    public BallController Ball;

    public int scoreKiri;
    public int scoreKanan;
    public int maxScore;

    public void addRightScore(int increment)
    {
        Ball.ResetBall();
        scoreKanan += increment;
        if (scoreKanan >= maxScore)
        {
            gameOver();
        }
    }

    public void addLeftScore(int increment)
    {
        Ball.ResetBall();
        scoreKiri += increment;
        if (scoreKiri >= maxScore)
        {
            gameOver();
        }
    }

    public void gameOver()
    {
        SceneManager.LoadScene("Menu");
    }

}
