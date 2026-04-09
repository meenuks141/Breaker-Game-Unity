using UnityEngine;

public class Brick : MonoBehaviour
{
    public int scoreValue = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindAnyObjectByType<GameManager>().AddScore(scoreValue);
        Destroy(gameObject);
    }
}
