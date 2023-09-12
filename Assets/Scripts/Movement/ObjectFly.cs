using UnityEngine;

public class ObjectFly : ProjectBehaviour
{
    [SerializeField] protected float moveSpeed = 10;
    [SerializeField] protected Vector3 direction = Vector3.right;

    void Update()
    {
        Move();
    }

    protected virtual void Move() {
        transform.parent.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
