using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
public Transform spawnPoint;
    public int score = 0;
    public int lives = 3;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;

    void Start()
    {
        UpdateUI();
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--;
        UpdateUI();

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
         else
        {
        Invoke("RespawnBall", 1f);
        }
    }
    void RespawnBall()
{
    Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
}

    void UpdateUI()
    {
        if(scoreText != null)
            scoreText.text = "Score: " + score;

        if(livesText != null)
            livesText.text = "Lives: " + lives;
    }
    public void CheckWin()
{
    if (GameObject.FindGameObjectsWithTag("Brick").Length == 0)
    {
        Debug.Log("You Win!");
        Time.timeScale = 0; // Stop the game
    }
}
}
