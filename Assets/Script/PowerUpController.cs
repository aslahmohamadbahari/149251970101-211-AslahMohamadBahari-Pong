using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    
    // Setting
    public PowerUpManager manager;

    // Speed Ball
    public Collider2D Ball;
    public float magnitudeBall;
    public float magnitudePaddle;
    public GameObject PaddleKanan;
    public GameObject PaddleKiri;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == CompareTag("SpeedBall"))
        {
            this.Ball.GetComponent<BallController>().activatePUSpeedUp(magnitudeBall);
            manager.RemovePowerUp(gameObject);
        }
        if (collision == CompareTag("SpeedPaddle"))
        {
            PaddleKanan.GetComponent<PaddleController>().PUSpeedPaddle();
            PaddleKiri.GetComponent<PaddleController>().PUSpeedPaddle();
            manager.RemovePowerUp(gameObject);
        }
        if (collision == CompareTag("ScalePaddle"))
        {
            PaddleKanan.GetComponent<PaddleController>().PUScalePaddle();
            PaddleKiri.GetComponent<PaddleController>().PUScalePaddle();
            manager.RemovePowerUp(gameObject);
        }
    }
}
