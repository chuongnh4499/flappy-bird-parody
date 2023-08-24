using UnityEngine;

public class BulletFly : MonoBehaviour
{
    [SerializeField] protected int moveSpeed = 10;
    [SerializeField] protected Vector3 direction = Vector3.right;
    private float rightEdge;

    private void Start()
    {
        rightEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x * -1f;
    }

    void FixedUpdate()
    {
        transform.parent.Translate(direction * moveSpeed * Time.deltaTime);

        Debug.Log("transform.parent.position.x: " + transform.parent.position.x);

        if (transform.parent.position.x >= rightEdge) {
            Destroy(transform.parent.gameObject);
        }

    }
}
