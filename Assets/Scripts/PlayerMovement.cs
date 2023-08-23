using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private static PlayerMovement instance;
    public static PlayerMovement Instance { get => instance; }
    private Vector3 direction;

    [SerializeField] private float gravity = -9.8f;
    [SerializeField] private float strength = 5f;

    private void Awake()
    {
        instance = this;
    }

    void FixedUpdate()
    {
        HandleInputMoveUp();
        // direction.y += gravity * Time.deltaTime;
        // Vector3 newPos = Vector3.Lerp(transform.parent.position, direction, 0.1f);
        // transform.parent.position = newPos;

        // direction.y += gravity * Time.deltaTime;
        // transform.parent.position += direction * Time.deltaTime;
    }

    public void SetDefaultDirection()
    {
        // direction = Vector3.zero;
        // Player.Instance.Rigidbody2DPlayer.velocity = Vector3.zero;
        Player.Instance.PlayerVelocity = Vector3.zero;
    }

    private void HandleInputMoveUp()
    {
        // For PC
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            MoveUp();
        }

        // For Mobile 
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) {
                MoveUp();
            }
        }
    }

    private void MoveUp() {
        // direction = Vector3.up * strength;
        // Player.Instance.velocity = Vector3.up * strength;
        // Player.Instance.Rigidbody2DPlayer.velocity = Vector3.up * strength;
        Player.Instance.PlayerVelocity = Vector3.up * strength;
    }
}
