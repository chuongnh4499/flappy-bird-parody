using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : ProjectBehaviour
{
    [SerializeField] protected List<Transform> points;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPoints();
    }

    protected virtual void LoadPoints()
    {
        if (points?.Count > 0) return;

        foreach (Transform point in transform)
        {
            points.Add(point);
        }

    }
    
    public virtual Transform GetRanDom()
    {
        int rand = Random.Range(0, points.Count);
        return points[rand];
    }
}
