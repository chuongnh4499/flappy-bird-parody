using System.Collections;
using System.Collections.Generic;
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
