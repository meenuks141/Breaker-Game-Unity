using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody2D rb;
    private GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(speed, speed);

        // Reference to GameManager
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.tag == "Brick")
    {
        // Increase ball speed
        rb.linearVelocity = rb.linearVelocity.normalized * (rb.linearVelocity.magnitude + 0.2f);

        // Add score via GameManager and check win
        if (gameManager != null)
        {
            gameManager.AddScore(10);  // 10 points per brick
            gameManager.CheckWin();    // Check if all bricks are destroyed
        }

        // Destroy the brick
        Destroy(collision.gameObject);
    }

    if (collision.gameObject.tag == "Bottom") // Detect if ball falls below paddle
    {
        if (gameManager != null)
        {
            gameManager.LoseLife();
        }
        Destroy(gameObject); // Remove the fallen ball
    }
}
  
}
