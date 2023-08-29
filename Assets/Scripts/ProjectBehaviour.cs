using UnityEngine;

public class ProjectBehaviour : MonoBehaviour
{
    protected void Reset()
    {
        LoadComponents();
    }

    protected virtual void Awake()
    {
        LoadComponents();
    }

    protected virtual void LoadComponents()
    {
        // For override
    }
}
