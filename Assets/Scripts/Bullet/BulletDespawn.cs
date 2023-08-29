using UnityEngine;

public class BulletDespawn : Despawn
{
    private float rightEdge;

    protected override void LoadComponents()
    {
        LoadCamera();
    }

    protected void LoadCamera()
    {
        rightEdge = Camera.main.ScreenToWorldPoint(Vector2.zero).x * -1;
    }

    protected override bool IsDespawn()
    {
        if (transform.parent.position.x > rightEdge) return true;
        return false;
    }
}
