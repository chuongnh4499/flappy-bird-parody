using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ProjectBehaviour
{
    [SerializeField] protected List<Transform> prefabs;
    public float spawnRate = 1f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPreFabs();
    }

    protected void LoadPreFabs()
    {
        if (prefabs?.Count > 0) return;

        Transform prefabsObj = gameObject.transform.Find("Prefabs");
        foreach (Transform prefab in prefabsObj)
        {
            prefabs.Add(prefab);
        }

        HidePreFabs();
    }

    protected void HidePreFabs()
    {
        foreach (Transform prefab in prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        StartCoroutine(Spawning());
    }

    private void OnDisable()
    {
        StopCoroutine(Spawning());
    }

    IEnumerator Spawning()
    {
        yield return new WaitForSeconds(spawnRate);

        GameObject prefab = Instantiate(prefabs[0].gameObject, transform.position, Quaternion.identity);

        if (prefab != null) prefab.gameObject.SetActive(true);

        StartCoroutine(Spawning());
    }

}
