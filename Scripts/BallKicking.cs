using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallKicking : MonoBehaviour
{
    public float ballPower = 400f;
    Rigidbody2D ballRigidBody;

    private void Awake()
    {
        ballRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
    }

    public  void BallMovement()
    {
          ballRigidBody.AddForce(-Vector2.right * ballPower, ForceMode2D.Impulse);  
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement whitePlayer = collision.GetComponent<PlayerMovement>();
        if(whitePlayer != null )
        {
            whitePlayer.whitePlayerKicked = true;
        }

        PlayerMovement redPlayer = collision.GetComponent<PlayerMovement>();
        if(redPlayer != null )
        {
            redPlayer.redPlayerKicked = true;
        }
    }
}
