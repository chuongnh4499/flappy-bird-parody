using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting = false;
    public GameObject prefab;

    void FixedUpdate()
    {
        Shooting();
    }

    protected virtual void Shooting()
    {
        if (isShooting) return;

        // Instantiate(prefab);
    }

}
