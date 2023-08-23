using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void Start()
    {
        StartCoroutine(SpawningPipes());
    }

    private void OnDisable()
    {
        StopCoroutine(SpawningPipes());
    }

    IEnumerator SpawningPipes()
    {
        yield return new WaitForSeconds(spawnRate);

        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);

        StartCoroutine(SpawningPipes());
    }

}