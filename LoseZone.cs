
using UnityEngine;

public class LoseZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindAnyObjectByType<GameManager>().LoseLife();
        Destroy(collision.gameObject);
    }
}