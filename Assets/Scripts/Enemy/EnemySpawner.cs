using UnityEngine;

public class EnemySpawner : SpawnerByCoroutine
{
    private static EnemySpawner instance;
    public static EnemySpawner Instance { get => instance; }

    protected override void OverridingValue()
    {
        base.SetSpawnRate(2.5f);
    }
    
    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.LogError("Only one EnemySpawner allow to exist");
        instance = this;
    }

    protected virtual void Start()
    {
        base.StartSpawningCoroutine();
    }

}
