using UnityEngine;

public class EnemyRandom : ProjectBehaviour
{
    [SerializeField] protected EnemyController enemyController;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadEnemyController();
    }

    protected virtual void LoadEnemyController()
    {
        if (enemyController != null) return;
        enemyController = GetComponent<EnemyController>();
        Debug.Log(transform.name + ": LoadEnemyController", gameObject);
    }

    // protected virtual void Start()
    // {
    //     EnemySpawning();
    // }

    // protected virtual void EnemySpawning()
    // {
    //     EnemyController.EnemySpawner.Spawning(transform.position, Quaternion.identity);
    //     Invoke(nameof(EnemySpawning), 0.5f);
    // }

}
