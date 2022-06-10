using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

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
        Debug.Log("Position : " + Movement);
    }

}
