using System.Collections;
using System.Collections.Generic;
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
}
