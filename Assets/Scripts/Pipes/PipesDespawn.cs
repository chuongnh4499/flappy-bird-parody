using UnityEngine;

public class PipesDespawn : DespawnByDistance
{
    protected override void DespawnObject()
    {
        PipesSpawner.Instance.Despawn(transform.parent.gameObject);
    }

}
