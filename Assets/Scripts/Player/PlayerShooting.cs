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
            AudioManager.Instance.ShootingSound();
            BulletSpawner.Instance.Spawning(shootingPoint.position, Quaternion.identity);
            InputManager.Instance.IsClickedMouseLeft = false;
        };
    }

}
