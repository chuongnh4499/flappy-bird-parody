using UnityEngine;

public class Player : MonoBehaviour
{
    // TODO: Refactor all below
    private static Player instance;
    public static Player Instance { get => instance; }

    protected Rigidbody2D rigidbody2DPlayer;
    public Rigidbody2D Rigidbody2DPlayer { get => rigidbody2DPlayer; }

    void Awake()
    {
        instance = this;
        rigidbody2DPlayer = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        // First position spawn player
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;

        // Reset velocity player
        rigidbody2DPlayer.velocity = Vector2.zero;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GameManager.Instance.GetStatusGame() == Status.PLAY) {
            if (other.gameObject.tag == "Obstacle") {
                GameManager.Instance.GameOver();
            }
            else if (other.gameObject.tag == "Scoring") {
                GameManager.Instance.IncreaseScore();
            }
        }
    }
}
