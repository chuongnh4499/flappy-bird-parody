using UnityEngine;

public class BulletFly : MonoBehaviour
{
    [SerializeField] protected int moveSpeed = 10;
    [SerializeField] protected Vector3 direction = Vector3.right;

    void FixedUpdate()
    {
        transform.parent.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
