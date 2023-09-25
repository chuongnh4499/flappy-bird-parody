
public class EnemyDespawn : DespawnByDistance
{
    protected override void DespawnObject()
    {
        EnemySpawner.Instance.Despawn(transform.parent.gameObject);
    }
}
