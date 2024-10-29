using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D myRigidBody;
    Vector2 movement;
    public bool whitePlayerKicked;
    public bool redPlayerKicked;
    private static bool isWhiteTurn = true;
    public bool isWhitePlayer;

     
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if((isWhitePlayer && isWhiteTurn) || (!isWhitePlayer && !isWhiteTurn))
        {
            movement.x = Input.GetAxis("Horizontal");
            movement.y = Input.GetAxis("Vertical");
        }
        else
        {
            movement = Vector2.zero;
        }      

        
    }

    void FixedUpdate()
    {
        myRigidBody.MovePosition(myRigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);  
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BallKicking ballKicking = collision.GetComponent<BallKicking>();
        if (ballKicking !=null)
        {
            ballKicking.BallMovement();
            SwitchTurn();
            Debug.Log(collision.name);
        }
    }

    void SwitchTurn()
    {
        isWhiteTurn = !isWhiteTurn;
    }
}
