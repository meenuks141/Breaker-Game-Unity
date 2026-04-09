
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10f;
    public float minX = -7f;
    public float maxX = 7f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        Vector3 pos = transform.position;
        pos.x += move * speed * Time.deltaTime;

        // Clamp position
        pos.x = Mathf.Clamp(pos.x, minX, maxX);

        transform.position = pos;
    }
}
