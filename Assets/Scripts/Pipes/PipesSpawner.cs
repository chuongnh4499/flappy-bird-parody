using UnityEngine;

public class PipesSpawner : SpawnerByCoroutine
{
    private static PipesSpawner instance;
    public static PipesSpawner Instance { get => instance; }

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.LogError("Only one PipesSpawner allow to exist");
        instance = this;
    }

    protected virtual void Start()
    {
        base.StartSpawningCoroutine();
    }

    protected override void OverridingValue()
    {
        base.SetPrefabName(Constants.PIPES_GREEN);
    }
}
