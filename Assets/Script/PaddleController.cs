using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    int normal = 5;
    private Rigidbody2D Rig;


    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement(getInput());
    }

    private Vector2 getInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void Movement (Vector2 Movement)
    {
        Rig.velocity = Movement;
    }
    public void activePUSpeedPaddle(float Magnitude)
    {
        Rig.velocity *= Magnitude;
    }
    public void PUSpeedPaddle()
    {
        speed += 1;
        StartCoroutine(intervalBuffPowerUp());
    }
    public void PUScalePaddle()
    {
        transform.localScale = new Vector2(0.3f, 5);
        StartCoroutine(intervalBuffPowerUp());
    }
    IEnumerator intervalBuffPowerUp()
    {
        yield return new WaitForSeconds(normal);
        speed = 4;
        transform.localScale = new Vector2(0.3f, 2.5f);
        StartCoroutine(intervalBuffPowerUp());
    }
}
