using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    public float speed = 1f;
    public float leftEdge;

    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 0.5f;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }
}
