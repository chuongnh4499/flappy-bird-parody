using System.Collections;
using UnityEngine;

public class SpawnerByCoroutine : Spawner
{
    [SerializeField] protected float spawnRate = 1f;
    protected string prefabName = null;

    protected void Start()
    {
        StartCoroutine(SpawningByCoroutine());
    }

    protected void OnDisable()
    {
        StopSpawningCoroutine();
    }

    protected IEnumerator SpawningByCoroutine()
    {
        yield return new WaitForSeconds(spawnRate);

        base.Spawning(transform.position, Quaternion.identity, prefabName);

        StartCoroutine(SpawningByCoroutine());
    }

    protected void StopSpawningCoroutine()
    {
        StopCoroutine(SpawningByCoroutine());
    }

    public void SetSpawnRate(float rate)
    {
        spawnRate = rate;
    }

    public void SetPrefabName(string name)
    {
        prefabName = name;
    }
}
