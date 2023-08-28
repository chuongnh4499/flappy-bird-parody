using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : Spawner
{
    private static PipesSpawner instance;
    public static PipesSpawner Instance { get => instance; }

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

        Spawning(transform.position, Quaternion.identity, Constants.PIPES_GREEN);

        StartCoroutine(SpawningPipes());
    }

}
