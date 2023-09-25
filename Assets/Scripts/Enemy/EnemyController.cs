using UnityEngine;

public class EnemyController : ProjectBehaviour
{
    [SerializeField] protected EnemySpawner enemySpawner;
    public EnemySpawner EnemySpawner { get => enemySpawner; }
    [SerializeField] protected SpawnPoints spawnPoints;
    public SpawnPoints SpawnPoints { get => spawnPoints; }
 
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadEnemySpawner();
        LoadSpawnPoints();
    }

    protected virtual void LoadEnemySpawner()
    {
        if (enemySpawner != null) return;
        enemySpawner = GetComponent<EnemySpawner>();
        Debug.Log(transform.name + ": LoadEnemySpawner", gameObject);
    }

    protected virtual void LoadSpawnPoints()
    {
        if (spawnPoints != null) return;
        spawnPoints = FindObjectOfType<SpawnPoints>();

        Debug.Log(transform.name + ": LoadSpawnPoints", gameObject);
    }
}
