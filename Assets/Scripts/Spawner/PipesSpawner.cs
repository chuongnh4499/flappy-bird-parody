using System.Collections;
using UnityEngine;

public class PipesSpawner : Spawner
{
    private static PipesSpawner instance;
    public static PipesSpawner Instance { get => instance; }
    [SerializeField] protected float spawnRate = 1f;

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.LogError("Only one PipesSpawner allow to exist");
        instance = this;
    }

    protected void Start()
    {
        StartCoroutine(SpawningPipes());
    }

    protected void OnDisable()
    {
        StopCoroutine(SpawningPipes());
    }

    protected IEnumerator SpawningPipes()
    {
        yield return new WaitForSeconds(spawnRate);

        base.Spawning(transform.position, Quaternion.identity, Constants.PIPES_GREEN);

        StartCoroutine(SpawningPipes());
    }

}
