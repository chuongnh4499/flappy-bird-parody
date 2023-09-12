using UnityEngine;

public class JunkRandom : ProjectBehaviour
{
    [SerializeField] protected JunkController junkController;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkController();
    }

    protected virtual void LoadJunkController()
    {
        if (junkController != null) return;
        junkController = GetComponent<JunkController>();
        Debug.Log(transform.name + ": LoadJunkController", gameObject);
    }

    // protected virtual void Start()
    // {
    //     JunkSpawning();
    // }

    // protected virtual void JunkSpawning()
    // {
    //     junkController.JunkSpawner.Spawning(transform.position, Quaternion.identity);
    //     Invoke(nameof(JunkSpawning), 0.5f);
    // }

}
