using UnityEngine;

public class JunkSpawner : SpawnerByCoroutine
{
    private static JunkSpawner instance;
    public static JunkSpawner Instance { get => instance; }

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.LogError("Only one JunkSpawner allow to exist");
        instance = this;
    }

    protected override void OverridingValue()
    {
        base.SetSpawnRate(2.5f);
    }
}
