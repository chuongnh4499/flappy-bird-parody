using UnityEngine;

public class PipesMovement : ProjectBehaviour
{
    public float speed = 5f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    void OnEnable()
    {
        MoveByRandomHeight();
    }

    private void Update()
    {
        MoveToLeft();
    }

    private void MoveByRandomHeight()
    {
        transform.parent.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }

    private void MoveToLeft()
    {
        transform.parent.position += Vector3.left * speed * Time.deltaTime;
    }
}
