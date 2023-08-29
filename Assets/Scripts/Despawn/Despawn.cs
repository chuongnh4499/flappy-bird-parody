public abstract class Despawn : ProjectBehaviour
{
    protected virtual void FixedUpdate()
    {
        Despawning();
    }

    protected virtual void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }

    protected virtual void Despawning()
    {
        if (!IsDespawn()) return;
        DespawnObject();
    }

    protected abstract bool IsDespawn();

}
