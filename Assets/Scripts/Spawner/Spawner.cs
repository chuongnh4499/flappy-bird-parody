using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : ProjectBehaviour
{
    [SerializeField] protected List<Transform> prefabs;
    public float spawnRate = 1f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPreFabs();
    }

    protected virtual void LoadPreFabs()
    {
        if (prefabs?.Count > 0) return;

        Transform prefabsObj = gameObject.transform.Find(Constants.PREFABS);
        foreach (Transform prefab in prefabsObj)
        {
            prefabs.Add(prefab);
        }

        HidePreFabs();
    }

    protected virtual void HidePreFabs()
    {
        foreach (Transform prefab in prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }

    public virtual GameObject Spawning(Vector3 position, Quaternion rotation, string prefabName = null)
    {
        GameObject original = GetPrefabByName(prefabName);

        if (original == null) {
            original = prefabs[0].gameObject;
            Debug.LogWarning("Prefab not found: " + prefabName);
        }
        
        GameObject prefab = Instantiate(original, position, rotation);

        if (prefab != null) prefab.gameObject.SetActive(true);

        return prefab;
    }

    public virtual GameObject GetPrefabByName(string prefabName)
    {
        foreach (Transform prefab in prefabs)
        {
            if (prefab.name == prefabName) return prefab.gameObject;
        }

        return null;
    }

}
