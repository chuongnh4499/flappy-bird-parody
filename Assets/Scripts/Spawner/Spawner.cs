using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Spawner : ProjectBehaviour
{
    [SerializeField] protected List<Transform> prefabs;
    [SerializeField] protected List<Transform> poolObjs;
    [SerializeField] protected Transform holder;

    protected override void LoadComponents()
    {
        LoadPreFabs();
        LoadHolder();
    }

    protected virtual void LoadHolder()
    {
        if (holder != null) return;
        holder = transform.Find(Constants.HOLDER);
        Debug.Log(transform.name + ": LoadHolder", gameObject);
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
        GameObject original;

        if (prefabName == null) {
            original = prefabs[0].gameObject;
        }
        else {
            original = GetPrefabByName(prefabName);
        }

        if (original == null) {
            Debug.LogWarning("Prefab not found: " + prefabName);
            return null;
        }

        GameObject newPrefab = GetObjectFromPool(original);

        newPrefab.transform.SetPositionAndRotation(position, rotation);
        newPrefab.transform.parent = holder;

        if (newPrefab != null) newPrefab.SetActive(true);

        return newPrefab;
    }

    public virtual GameObject GetPrefabByName(string prefabName)
    {
        foreach (Transform prefab in prefabs)
        {
            if (prefab.name == prefabName) return prefab.gameObject;
        }

        return null;
    }

    public virtual void Despawn(GameObject obj)
    {
        poolObjs.Add(obj.transform);
        obj.SetActive(false);
    }

    protected virtual GameObject GetObjectFromPool(GameObject prefab)
    {
        foreach(Transform obj in poolObjs) 
        {
            if (obj.name == prefab.name) {
                poolObjs.Remove(obj);
                return obj.gameObject;
            }
        }

        GameObject newPrefab = Instantiate(prefab);
        newPrefab.name = prefab.name;

        return newPrefab;
    }

    public virtual void DestroyAllObj()
    {
        if (!poolObjs.Any() && holder.childCount == 0) return;

        foreach (Transform child in holder)
        {
            Destroy(child.gameObject);
        }

        poolObjs.Clear();
    }
}
