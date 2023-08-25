using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float strength = 7f;

    void FixedUpdate()
    {
        PlayerMoveUp();
    }

    private void PlayerMoveUp()
    {
        // For PC
        if (InputManager.Instance.IsPressSpace)
        {
            MoveUp();
            InputManager.Instance.IsPressSpace = false;
        }

        // For Mobile 
        // if (Input.touchCount > 0)
        // {
            // Touch touch = Input.GetTouch(0);
            // if (touch.phase == TouchPhase.Began)
            // {
            //     MoveUp();
            // }
        // }
    }

    private void MoveUp()
    {
        Player.Instance.Rigidbody2DPlayer.velocity = Vector2.zero;
        Player.Instance.Rigidbody2DPlayer.AddForce(Vector2.up * strength, ForceMode2D.Impulse);
    }
}
