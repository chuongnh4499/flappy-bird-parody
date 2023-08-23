using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player instance;
    public static Player Instance { get => instance; }

    protected Rigidbody2D rigidbody2DPlayer;
    public Rigidbody2D Rigidbody2DPlayer { get => rigidbody2DPlayer; }
    
    protected Vector3 playerVelocity;
    public Vector3 PlayerVelocity { get => playerVelocity; set => playerVelocity = value; }


    void Awake()
    {
        instance = this;
        rigidbody2DPlayer = GetComponent<Rigidbody2D>();
        rigidbody2DPlayer.velocity = PlayerVelocity;
    }

    void OnEnable()
    {
        // First position spawn player
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        PlayerMovement.Instance.SetDefaultDirection();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle") {
            GameManager.Instance.GameOver();
        }
        else if (other.gameObject.tag == "Scoring") {
            GameManager.Instance.IncreaseScore();
        }
    }
}
