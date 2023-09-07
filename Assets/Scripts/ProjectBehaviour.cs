using UnityEngine;

public class ProjectBehaviour : MonoBehaviour
{
    protected void Reset()
    {
        LoadComponents();
        ResetValue();
    }

    protected virtual void Awake()
    {
        LoadComponents();
        OverridingValue();
    }

    protected virtual void LoadComponents()
    {
        // For override
    }

    protected virtual void OverridingValue()
    {
        // For override
    }

    protected virtual void ResetValue()
    {
        // For override
    }
}
