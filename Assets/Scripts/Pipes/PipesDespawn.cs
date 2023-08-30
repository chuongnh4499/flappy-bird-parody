using UnityEngine;

public class PipesDespawn : Despawn
{
    private float leftEdge;

    protected override void LoadComponents()
    {
        LoadCamera();
    }

    protected void LoadCamera()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 0.5f;
    }

    protected override bool IsDespawn()
    {
        if (transform.parent.position.x < leftEdge) return true;
        return false;
    }

    protected override void DespawnObject()
    {
        // base.DespawnObject();
        PipesSpawner.Instance.Despawn(transform.parent.gameObject);
    }

}
