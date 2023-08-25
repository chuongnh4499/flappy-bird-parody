using UnityEngine;

public class PipesGreen : MonoBehaviour
{   
    public float speed = 5f;
    private float leftEdge;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    void OnEnable()
    {
        transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
    
    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 0.5f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }
}
