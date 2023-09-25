using System.Collections;
using UnityEngine;

public class SpawnerByCoroutine : Spawner
{
    [SerializeField] protected float spawnRate = 1f;
    protected string prefabName = null;
    // protected Vector3 spawnPosition;
    // protected Quaternion spawnRotation;

    protected void OnDisable()
    {
        StopSpawningCoroutine();
    }

    protected virtual IEnumerator SpawningByCoroutine()
    {
        HandleBeforeSpawning();

        yield return new WaitForSeconds(spawnRate);

        base.Spawning(transform.position, Quaternion.identity, prefabName);

        StartCoroutine(SpawningByCoroutine());
    }

    protected void StartSpawningCoroutine()
    {
        StartCoroutine(SpawningByCoroutine());
    }

    protected void StopSpawningCoroutine()
    {
        StopCoroutine(SpawningByCoroutine());
    }

    protected virtual void HandleBeforeSpawning()
    {
        // For override
    }

    // Setter & Getter
    public void SetSpawnRate(float rate)
    {
        spawnRate = rate;
    }

    public void SetPrefabName(string name)
    {
        prefabName = name;
    }
}
