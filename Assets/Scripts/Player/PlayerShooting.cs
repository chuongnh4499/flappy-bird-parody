using UnityEngine;

public class PlayerShooting : ProjectBehaviour
{
    [SerializeField] protected Transform shootingPoint;

    void FixedUpdate()
    {
        Shooting();
    }

    protected void Shooting()
    {
        if (InputManager.Instance.IsClickedMouseLeft) {
            BulletSpawner.Instance.Spawning(shootingPoint.transform.position, Quaternion.identity);
            
            InputManager.Instance.IsClickedMouseLeft = false;
        };

    }

}
