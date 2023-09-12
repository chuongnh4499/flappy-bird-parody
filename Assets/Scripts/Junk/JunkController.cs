using UnityEngine;

public class JunkController : ProjectBehaviour
{
    [SerializeField] protected JunkSpawner junkSpawner;
    public JunkSpawner JunkSpawner { get => junkSpawner; }
 
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkSpawner();
    }

    protected virtual void LoadJunkSpawner()
    {
        if (junkSpawner != null) return;
        junkSpawner = GetComponent<JunkSpawner>();
        Debug.Log(transform.name + ": LoadJunkSpawner", gameObject);
    }
}
